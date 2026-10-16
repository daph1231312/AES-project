# AES Encryption Tool (Windows Forms, C#)

A small desktop app that encrypts and decrypts text with **AES**. You choose the key size
(128, 192 or 256 bit) and the cipher mode (ECB, CBC or CFB) and see how they change the result.

## Features

- Encrypt or decrypt text typed into the window, with a key you enter
- Key sizes: AES-128, AES-192, AES-256
- Modes: ECB, CBC, CFB
- Output shown as Base64; the random IV is stored in front of the encrypted data and read back when decrypting
- After encrypting, the result is written to `encrypted.txt`; the **Load File** button loads it back for decryption

## Requirements

- Windows (it is a Windows Forms app)
- Visual Studio 2019 or newer with the **.NET desktop development** workload (targets .NET Framework 4.7.2)
- No accounts, packages or API keys

## Run it

1. Clone the repository and open `balls.slnx` in Visual Studio (the project folder is named `balls`).
2. Press **F5** to build and run.
3. Type a message and a key, pick key length and mode, click **Encrypt**. Copy the result,
   or use **Load File**, then click **Decrypt** to get the message back.

## How it works

- `balls/AesHelper.cs`: `ConfigureAes` sets the key (the typed text is converted to UTF-8 bytes and
  cut or zero-padded to the chosen key size), the mode, and PKCS7 padding, and creates a random IV for CBC/CFB.
  `Encrypt` writes `[IV][encrypted bytes]` and returns it as Base64; `Decrypt` reverses it.
- `balls/Form1.cs`: the window and button handlers.

## Limitations (this is a learning project)

- The key is the typed text padded with zero bytes; it does not use a key-derivation function such as PBKDF2.
- There is no authentication of the data (no GCM or HMAC), so tampering is not detected.
- ECB mode is included only to show why it is a bad idea: identical blocks give identical output.
- Do not use it to protect real secrets.

---

## Background notes: AES, key sizes and modes

What is AES?

AES (Advanced Encryption Standard) is a block cipher, which means it encrypts data in fixed-size chunks called blocks. 
Every block is always 128 bits (16 bytes) regardless of the key size. If your text is shorter than 16 bytes it gets padded to fill the block. 
If it's longer it gets split into multiple blocks and each one is encrypted separately. The number of rounds (how many times the data gets scrambled) depends on the key size — 
more rounds means harder to crack but slightly slower.

Difference between AES-128, AES-192, and AES-256

AES-128 uses a 128 bit key and runs 10 rounds of scrambling. It is considered strong and is good enough for most everyday uses. 
AES-192 uses a 192 bit key and runs 12 rounds, making it stronger and more suitable for high security systems. 
AES-256 uses a 256 bit key and runs 14 rounds, making it the strongest of the three and is commonly used in military and government level encryption. 
The key size does not change the block size, it only changes how many times the data gets scrambled. A longer key means more rounds which makes brute forcing it exponentially harder.

Difference between ECB, CBC, and CFB

ECB (Electronic Codebook) is the simplest mode and does not use an IV. Its biggest weakness is that the same input always produces the same output, meaning an attacker 
can spot patterns in the cipher text without even decrypting it. CBC (Cipher Block Chaining) uses a random IV and chains each block to the previous one, so identical 
inputs produce completely different outputs every time, making it much harder to crack. CFB (Cipher Feedback) also uses a random IV and works similarly to CBC but operates on 
smaller chunks of data at a time, making it useful for streaming data. Both CBC and CFB are significantly more secure than ECB for this reason.
