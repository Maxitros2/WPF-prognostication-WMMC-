using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Png_program.Resources.Controls.utils
{
    public static class CryptHelper
    {
        public static string ComputeHash(string input)
        {
            HashAlgorithm algorithm = SHA256.Create();
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
