using SecureCode.Security;
using System;

namespace SecureCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var cipherText = DESEncryption.EncryptText("Hello rhis is ra");
            var decryptedText = DESEncryption.DecryptText(cipherText);
        }
    }
}
