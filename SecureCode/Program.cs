using SecureCode.Common;
using SecureCode.TextEncoding;
using SecureCode.Helper;
using SecureCode.Security;
using System;
using System.Linq;

namespace SecureCode
{
    class Program
    {
        static string plainText = "Encrypt me or I will be open for everyone to read";
        static void Main(string[] args)
        {
            //EncryptUsingDES();
            //EncryptUsingAES();
            EncodingUsingBase64();
        }
        static void EncryptUsingDES()
        {
            var cipherText = DESEncryption.Encrypt(plainText);
            var decryptedText = DESEncryption.Decrypt(cipherText);
        }
        static void EncryptUsingAES()
        {
            var cipherText = AESEncryption.Encrypt(plainText);
            var decryptedText = AESEncryption.Decrypt(cipherText);
        }
        static void EncodingUsingBase64()
        {
            var encodedText = Base64Encoding.Encode(plainText);
            var decodedText = Base64Encoding.Decode(encodedText);
        }
    }
}
