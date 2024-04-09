using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJWT.Models
{
    public class CreateToken
    {
        public string GenerateToken()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi..//1234567api///api");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(5), signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);
        }

        public string GenerateTokenToAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("aspnetcoreapiapi..//1234567api///api");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim (ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                new Claim (ClaimTypes.Role, "Admin"),
                new Claim (ClaimTypes.Role, "Visitor")
            };

            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", claims: claims, notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(5), signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(token);
        }
    }
}
