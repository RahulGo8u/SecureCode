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
        public static string EncryptionKey = "63$#DHJngst";
        public static byte[] IVArr = new byte[] { 89, 45, 34, 89, 21, 89, 54, 21 };
    }
}
