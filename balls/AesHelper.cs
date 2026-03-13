using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//first off we need a class that will take the text and the key and the settings
//and return the encrypted/decrypted text
//we need 3 methods in this class 1 for encryption 1 for decryption and 1 for the settings
//the issue is idk what classes are used for. What methods are used for Im  lacking some basic info and thats why this isnt sitting right w me
namespace balls
{
    public static class AesHelper  //static cuz we dont need to create objects we can just call it like AesHelper.Encrypt(...) etc..

    {
        private static void ConfigureAes(Aes aes, string key, CipherMode mode, int keyLength) //method needed for both enc and dec its for the options.
                                                                                              // Sets up the AES object with the correct key, mode, and key size
        {
            int keyBytes = keyLength / 8; //we  divide the bits by 8 to get the exact byte size
            byte[] keyArray = new byte[keyBytes]; //made an array called keyArray of type byte which will store byte size
            byte[] keySource = Encoding.UTF8.GetBytes(key); //converts the users key string into bytes
            Array.Copy(keySource, keyArray, Math.Min(keySource.Length, keyBytes)); //copies the user's key bytes into keyArray. math.min makes sure we dont copy more bytes than the array can hold.

            
            aes.KeySize = keyLength;  //tell the aes object the key size we'll be using.
            aes.Mode = mode;        //set the mode chosen by the user
            aes.Key = keyArray; //assign the prepared key bytes to the aes object. Needs to be set after size so it doesnt reset.
            aes.Padding = PaddingMode.PKCS7;   //idk the use case but it fills incomplete blocks so AES can always work on full 16-byte blocks

            if (mode == CipherMode.ECB)
                aes.IV = new byte[16];  //ecb doesnt require an IV so we set it to something valid so we dont get an error
                                        // 16 zero bytes — ignored by ECB but required by the API
            else
                aes.GenerateIV();       //cbc and cfb needs random IV's for security
                                        // GenerateIV() creates a new random 16-byte IV each time
                                        //stores the iv in aes.IV
        }

        public static string Encrypt(string plainText, string key, CipherMode mode, int keyLength)
        {
            using (Aes aes = Aes.Create())  //Aes.Create() means it will create a new Aes encryption object. But what is Aes in this case???
                                            //using clears memory from it after we are done with it.
            {
                ConfigureAes(aes, key, mode, keyLength);    // Call our helper method to apply key, mode, keysize to the aes object
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);    //converting our plaintext into bytes CUZ AES WORKS ON BYTES!!!
                using (MemoryStream ms = new MemoryStream())      //We use memorystream because it lets us read or write data directly from memory without needing to allocate or deallocate memory.
                {                                                 //temporary buffer that holds bytes in memory

                    ms.Write(aes.IV, 0, aes.IV.Length);    // Write the IV (Initialization Vector) at the very start of the output
                                                           // We need to save it here so that Decrypt can read it back later
                                                           // aes.IV is a byte array, aes.IV.Length is how many bytes it has (always 16)
                                                           /* we write those 16 bytes INTO the output FIRST. The randomly generated IV that was storede in aes.IV
                                                            ```
                                                            So the encrypted output looks like this in memory:
                                                            ```
                                                            [IV(16 bytes)][encrypted data(rest of bytes)] */

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))    // CryptoStream wraps the MemoryStream and automatically encrypts whatever bytes we write into it. Cryptostream object use is writing data to the CryptSt object
                                                                                                                     //first argument: destination stream, The stream on which the result of cryptographic transformation is written to.                  
                                                                                                                     // CryptoStreamMode.Write means we are writing (encrypting) data into it
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);          // Write the plain bytes into the CryptoStream — it encrypts them automatically
                        cs.FlushFinalBlock();                                //finished the encryption and handles padding
                    }
                    return Convert.ToBase64String(ms.ToArray());              // Convert all the bytes in the MemoryStream to a Base64 string
                                                                             // Base64 makes binary data safe to display and store as readable text
                }
            }
        }

        public static string Decrypt(string cipherText, string key, CipherMode mode, int keyLength)
        {
            using (Aes aes = Aes.Create())
            {
                ConfigureAes(aes, key, mode, keyLength);                      //configure AES the same way as encrypt so the data matches
                byte[] fullCipher = Convert.FromBase64String(cipherText);     //converts the Base64 data back into its raw bytes. Reversing what we did in encryption
                byte[] iv = new byte[16];                                     //this is where the iv will be stored. AES block size is always 16 bytes so IV is always 16 bytes
                byte[] cipherBytes = new byte[fullCipher.Length - iv.Length]; // Create an array for the actual cipher bytes (everything after the IV)    

                Array.Copy(fullCipher, iv, iv.Length);                        //copy the first 16 bytes we converted in fullCipher into iv. These are the IV bytes we saved during encryption
                                                                              // grab the first 16 bytes = the IV we saved/hid
                Array.Copy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length);  //copy the rest of the bytes after IV. iv.Length as the starting position ensures we skip past the iv we just read 
                
                aes.IV = iv;                  //give the extracted iv back to the aes object so it can be decrypted correctly. Without the correct iv the decryption will produce garbage output

                using (MemoryStream ms = new MemoryStream(cipherBytes))           //wrapping the cipherBytes so we can read from memory
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))   //wraps the memorystream and automatically decrypts as we read. CryptoStreamMode.Read means we are reading/decrypting data out of it. First argument is the source in this case.
                using (StreamReader sr = new StreamReader(cs))             //streamreader lets us read the decrypted bytes from cs  as a normal string, stores it in sr.
                {
                    return sr.ReadToEnd();                              // ReadToEnd() reads all the decrypted bytes and converts to a string
                }
            }
        }
    }
}
