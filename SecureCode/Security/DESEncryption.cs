using SecureCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCode.Security
{
    public static class DESEncryption
    {
        #region Helper Functions
        public static string EncryptText(string text)
        {
            string res = text;
            if (!string.IsNullOrEmpty(text))
            {
                string key = Constants.EncryptionKey;
                byte[] keyArr = key.Length > 8 ? Encoding.UTF8.GetBytes(key.Substring(0, 8)) : Encoding.UTF8.GetBytes(key);
                byte[] inputArr = new byte[text.Length];
            }
            return res;
        }
        public static string DecryptText(string text)
        {
            string res = text;
            if (!string.IsNullOrEmpty(text))
            {

            }
            return res;
        }
        #endregion Helper Functions
    }
}
