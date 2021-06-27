using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsManagerWindowsApp.Utilities
{
    public class Utils
    {
        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string StringToHex(string hexstring)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char t in hexstring)
            {
                if (Convert.ToInt32(t).ToString("X").Length == 1)
                    sb.Append("000" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 2)
                    sb.Append("00" + Convert.ToInt32(t).ToString("X"));
                if (Convert.ToInt32(t).ToString("X").Length == 3)
                    sb.Append("0" + Convert.ToInt32(t).ToString("X"));
            }
            return sb.ToString();
        }
    }
}
