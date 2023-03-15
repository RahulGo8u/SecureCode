using SecureCode.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureCode.Security
{
    public static class AESEncryption
    {
        static byte[] key;
        static byte[] iv;
        static void GenerateKeys()
        {
            Aes aes = Aes.Create();
            key = aes.Key;
            iv = aes.IV;
        }
        #region Helper Functions
        public static string Encrypt(string text)
        {
            return EncryptText(text);
        }
        
        public static string Decrypt(string text)
        {
            return DecryptCipher(text, key);
        }

        #endregion Helper Functions

        private static string EncryptText(string text)
        {
            GenerateKeys();
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;
            var encryptor = aes.CreateEncryptor(aes.Key , aes.IV);
            using MemoryStream ms = new();
            using CryptoStream cs = new((Stream)ms, encryptor, CryptoStreamMode.Write);
            var inputArray = Encoding.UTF8.GetBytes(text);
            
            
            using StreamWriter sw = new((Stream)cs);
            sw.Write(text);
            return Convert.ToBase64String(ms.ToArray());
        }

        private static string DecryptCipher(string cipherText, byte[] key)
        {
            byte[] iv = new byte[16];
            using AesManaged aes = new();
            var encryptor = aes.CreateDecryptor(key, iv);
            byte[] inputTextArray = Convert.FromBase64String(cipherText);
            using MemoryStream ms = new();
            using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);
            using StreamReader sr = new(cs);
            return sr.ReadToEnd();
        }
    }
}
