using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IFTP1.Servicios
{
    public static class Encryptor
    {
        public static string Hash(string value)
        {
            var md5_encryptor = new MD5CryptoServiceProvider();
            var md5_data = md5_encryptor.ComputeHash(Encoding.ASCII.GetBytes(value));
            return (new ASCIIEncoding()).GetString(md5_data);
        }
    }
}
