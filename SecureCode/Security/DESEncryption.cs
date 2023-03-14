using SecureCode.Common;
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
    public static class DESEncryption
    {
        #region Helper Functions
        public static string EncryptText(string text)
        {
            return DESEncrypt(text);
        }
        public static string DecryptText(string text)
        {
            return DESDecrypt(text);
        }        
        #endregion Helper Functions

        /// <summary>
        /// IV: Initialization Vector
        /// Plain Text: Value to Encrypt
        /// Encryption Key: Secret key used for encryption
        /// DES CreateEncryptor uses Key and IV to encrypt plain text
        /// After encryption convert the memory stream to base 64
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        private static string DESEncrypt(string plainText)
        {
            var keyArray = Constants.EncryptionKey.Length > 8 ? EncodingHelper.GetUTF8ByteArray(Constants.EncryptionKey.Substring(0, 8)) : EncodingHelper.GetUTF8ByteArray(Constants.EncryptionKey);
            var plainTextArray = EncodingHelper.GetUTF8ByteArray(plainText);
            var ivArray = Constants.EncodedIV;
            using DESCryptoServiceProvider des = new();
            using MemoryStream ms = new();
            try
            {
                using CryptoStream cs = new(ms, des.CreateEncryptor(keyArray, ivArray), CryptoStreamMode.Write);
                cs.Write(plainTextArray, 0, plainTextArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                throw;
            }
        }
        private static string DESDecrypt(string cipherText)
        {
            var keyArray = Constants.EncryptionKey.Length > 8 ? EncodingHelper.GetUTF8ByteArray(Constants.EncryptionKey.Substring(0, 8)) : EncodingHelper.GetUTF8ByteArray(Constants.EncryptionKey);
            var ivArray = Constants.EncodedIV;
            var encryptedTextArray = Convert.FromBase64String(cipherText.Replace(" ", "+"));
            using DESCryptoServiceProvider des = new();
            using MemoryStream ms = new();
            try
            {
                using CryptoStream cs = new(ms, des.CreateDecryptor(keyArray, ivArray), CryptoStreamMode.Write);
                cs.Write(encryptedTextArray, 0, encryptedTextArray.Length);
                cs.FlushFinalBlock();
                return EncodingHelper.GetUTF8string(ms.ToArray());
            }
            catch
            {
                throw;
            }
        }
    }
}