using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace balls
{
    // you need three classes one for making the encryptio/decryption function 
    // class to store data to use later to print 
    // this is the class when you gonna make the code where you gonna print the data that has been stored in the previous class 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   //builds all the visual controls from the designer file

            ModeComboBox.Items.AddRange(new[] { "ECB", "CBC", "CFB" });    //populate the dropdown with the AES cipher modes
            ModeComboBox.SelectedIndex = 0;    //pre select the first option by default.

            KeyLengthComboBox.Items.AddRange(new[] { "128", "192", "256" });
            KeyLengthComboBox.SelectedIndex = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string Plaintext = Plaintextbox.Text;
            string Key = Keytextbox.Text;
            if (Plaintext.Length == 0)
            {
                MessageBox.Show("Enter a plain text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (Key.Length == 0)
                {

                    MessageBox.Show("Enter a key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }

            ExecuteOperation("Encrypt");
            
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string Plaintext = Plaintextbox.Text;
            string Key = Keytextbox.Text;
            if (Plaintext.Length == 0)
            {
                MessageBox.Show("Enter a plain text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (Key.Length == 0)
                {

                    MessageBox.Show("Enter a key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ExecuteOperation("Decrypt");
        }

        private void ExecuteOperation(string operation)
        {
            try
            {
                string plainText = Plaintextbox.Text;
                string key = Keytextbox.Text;
                int keyLength = int.Parse(KeyLengthComboBox.SelectedItem.ToString());  /*The dropdown gives us an object, not a number. So we first call .ToString() to turn it into "128", 
                                                                                        * then int.Parse() to turn that into the actual number 128.
                                                                                        * result` is an `AesResult` object — and yes, we overrode `ToString()`            
                                                                                        * * The rule to remember
                                                                                       .ToString() behaves differently depending on what object you call it on:
                                                                                        What .ToString() returns if we call it on:
                                                                                        result (AesResult)  = Our custom formatted output 
                                                                                        SelectedItem (dropdown)  = Just the raw value like "128"
                                                                                        Our override only affects AesResult objects. Everything else 
                                                                                        uses the default .ToString() which just returns the value as a string. We didnt use it with the class we have overriden it in so its the normal one*/
               
                CipherMode mode = GetCipherMode(ModeComboBox.SelectedItem.ToString()); //reads the choice and converts it into ciphermode which AES can understand AES only accepts the enum.

                string resultText;

                if (operation == "Encrypt")
                {
                    resultText = AesHelper.Encrypt(plainText, key, mode, keyLength);        //calls encrypt method from aeshelper class with the chosen variables and stores the end value in resulttext
                }
                else
                {
                    resultText = AesHelper.Decrypt(plainText, key, mode, keyLength);
                }
                
                if (operation == "Encrypt")
                {
                    File.WriteAllText("encrypted.txt", resultText);                         //creates a file where the encrypted text will be stored if there was an encryption op.
                }
             
                ResultTextbox.Text = resultText;         //This calls the ToString() we wrote in AesResult.cs which formats everything into readable lines and puts it in the output textbox.
            }
            catch (Exception ex)                                    //catches errors?
            {
                MessageBox.Show("Operation failed: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("encrypted.txt"))
            {
                MessageBox.Show("No encrypted file found. Encrypt something first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Plaintextbox.Text = File.ReadAllText("encrypted.txt");
        }
       

        private CipherMode GetCipherMode(string mode)
        {
            switch (mode)
            {
                case "ECB": return CipherMode.ECB;
                case "CBC": return CipherMode.CBC;
                case "CFB": return CipherMode.CFB;
                default: throw new ArgumentException("Invalid cipher mode: " + mode);
            }
        }
    }
}
    

