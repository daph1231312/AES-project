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
