using System;
namespace LibMediaServiceCommon
{
    public class Base64
    {
        public Base64 ()
        {
        }
        
        public static string EncodeTo64(string toEncode)
        {
            //byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            byte[] toEncodeAsBytes = System.Text.UTF8Encoding.UTF8.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        
        public static string DecodeFrom64(string encodedData)
        {
          byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
          string returnValue = System.Text.UTF8Encoding.UTF8.GetString(encodedDataAsBytes);
          return returnValue;
        }
 
        
    }
}

