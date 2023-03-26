namespace ProjectPlatoonMedicServer.Security.Models
{
    public class PasswordHash
    {
        public PasswordHash(string password, string salt)
        {
            Password = password;
            Salt = salt;
        }

        public string Password { get; }
        public string Salt { get; }
    }
}
