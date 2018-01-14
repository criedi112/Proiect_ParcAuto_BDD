using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BDD_interface_like
{
    class Encryption
    {
        private static String salt = "shaorma";
        public String EncryptPassword(String password)
        {
            String encryptedPassword = "";
            String saltedPassword = password + salt;

            HashAlgorithm algorithm = new SHA512Managed();

            byte[] hash = algorithm.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword));

            foreach (byte b in hash)
            {
                encryptedPassword += b.ToString("X2");
            }

            return encryptedPassword = encryptedPassword.Length <= 50 ? encryptedPassword : encryptedPassword.Substring(0, 50);
        }
    }
}
