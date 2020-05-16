using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using relc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace relc.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            var passwordHasher = new PasswordHasher<Login>();

            return passwordHasher.HashPassword(new Login(), password);
        }

        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            var passwordHasher = new PasswordHasher<Login>();

            var result = passwordHasher.VerifyHashedPassword(new Login(), hashedPassword, password);
            return result != 0;
        }
    }
}
