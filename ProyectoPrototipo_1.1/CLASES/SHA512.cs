using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace ProyectoPrototipo_1._1.CLASES
{
    public class SHA512
    {
        public string ComputeHash(byte[] input)
        {
            using (SHA512Managed sha512 = new())
            {
                byte[] hashBytes = sha512.ComputeHash(input);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
