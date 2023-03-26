using System;
using System.Security.Cryptography;
using ProjectPlatoonMedicServer.Security.Models;

namespace ProjectPlatoonMedicServer.Security
{
    public class PasswordHasher : IHashProvider
    {
        private const int WorkFactor = 10000;

        public string Hash(string input)
        {
            var saltBytes = new byte[16];
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngCryptoServiceProvider.GetBytes(saltBytes);
            }
            var salt = Convert.ToBase64String(saltBytes);

            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(input, saltBytes, WorkFactor);
            var hash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32));

            return $"{hash}:{salt}";
        }

        public bool Verify(string input, string hash)
        {
            var parts = hash.Split(':');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid hash format");
            }
            var hashValue = parts[0];
            var salt = parts[1];

            var saltBytes = Convert.FromBase64String(salt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(input, saltBytes, WorkFactor);
            var hashedInput = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32));

            return hashedInput == hashValue;
        }
    }
}
