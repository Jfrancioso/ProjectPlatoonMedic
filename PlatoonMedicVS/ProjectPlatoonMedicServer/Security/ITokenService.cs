namespace ProjectPlatoonMedicServer.Security.Models
{
    public interface ITokenService
    {
        string GenerateToken(int userId, string username);
        string GenerateToken(int userId, string username, string role);
    }
}
