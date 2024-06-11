using System.Security.Claims;

namespace MegaGame.Api.Settings.Jwt
{
    public interface IJwtExtension
    {
        string GenerateToken(long id, string role);

        IEnumerable<Claim> DecodeToken(string token);
    }
}
