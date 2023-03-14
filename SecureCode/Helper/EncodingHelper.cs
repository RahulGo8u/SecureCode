using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCode.Helper
{
    public static class EncodingHelper
    {
        public static byte[] GetUTF8ByteArray(string text) {
            return Encoding.UTF8.GetBytes(text);
        }
        public static string GetUTF8string(byte[] array)
        {
            return Encoding.UTF8.GetString(array);
        }
    }
}
