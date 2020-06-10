using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Collections.Generic;

namespace AuthDataLayer.Utils
{
    public class PasswordHash : IPasswordHash
    {
        public string GetHash(string password)
        {
            using (var hash = SHA1.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
            }
        }
    }
}
