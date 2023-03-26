using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjectPlatoonMedicServer.Security
{
    public class HashProvider : IHashProvider
    {
        public string Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new StringBuilder to collect the bytes and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        public bool Verify(string input, string hash)
        {
            // Hash the input string and compare it to the saved hash.
            string hashOfInput = Hash(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
