namespace ProjectPlatoonMedicServer.Security
{
    public interface IHashProvider
    {
        string Hash(string input);
        bool Verify(string input, string hash);
    }
}
