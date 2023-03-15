using System;
using System.Text;

namespace SecureCode.TextEncoding
{
    public static class Base64Encoding
    {
        #region Helper functions
        public static string Encode(string text)
        {
            return ConvertToBase64String(text);
        }
        public static string Decode(string encodedText)
        {
            return ConvertFromBase64String(encodedText);
        }
        #endregion Helper functions
        static string ConvertToBase64String(string text)
        {
            byte[] textArray = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(textArray);
        }
        static string ConvertFromBase64String(string encodedText)
        {
            byte[] encodedTextArray = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(encodedTextArray);
        }
    }
}
