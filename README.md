### Secure Code

- Implementing different types of data encryption and encoding methodologies to secure data.

# Encryption Methodologies
- DES
- AES

# Encoding Methodologies
- Base 64

## DES(Data Encryption Standard)

### About DES
- It is created by IBM in 1970.
- It uses a symmetric key algorithm.

### Parameters
- Input: It accepts 64bits of Plain text as an input.
- Output: It encrypts input data and outputs 64bits of Cipher text.
- Key: The secret key which is provided is of 64 bits but whats being used is of 56 bits.

## Base 64
- It converts plain text to Base64 encoded Text

### Usage
- When sending images, email attachments or any other thing. We encode them and send instead of sendig file.

### Encoding Process
- The text is encoded into a byte array.
- Each characted is encoded to its respective binary value.
- Each bytes are then encoded to base 64 text string

### Decoding Process
- Get the byte array of base64 encoded string
- Convert the byte array to string value after decoding it using UTF8.
