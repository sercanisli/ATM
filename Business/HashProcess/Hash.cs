using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.HashProcess
{
    public class Hash
    {
        public static string getHashMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] arr = Encoding.UTF8.GetBytes(text);
            arr = md5.ComputeHash(arr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in arr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
