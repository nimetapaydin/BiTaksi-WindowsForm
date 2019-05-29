using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BiTaksi
{
    static class Common
    {
        public static string md5HASH(string txt)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] btr = Encoding.UTF8.GetBytes(txt); // 
            btr = md5.ComputeHash(btr); // metini hashliyor

            StringBuilder sb = new StringBuilder();

            // hash içeren byte dizi string'e çeviriyoruz
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        public static int uniqueID()
        {
            return int.Parse(DateTime.Now.ToString("yyddHHmmss"));
        }
    }
}
