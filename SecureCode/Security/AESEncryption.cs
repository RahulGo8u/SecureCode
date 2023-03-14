using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCode.Security
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
    public static class AESEncryption
    {
    }
}
