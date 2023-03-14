using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureCode.Common
{
    public static class Constants
    {
        //move this to configuration
        public static string EncryptionKey = "12345678";
        public static byte[] EncodedIV = new byte[] { 89, 45, 34, 89, 21, 89, 54, 21 };
    }
}
