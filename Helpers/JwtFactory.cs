using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ErbAppsAPI.Models;
using Microsoft.IdentityModel.Tokens;

namespace ErbAppsAPI.Helpers
{
    public class JwtFactory
    {
        //private const SecurityAlgorithms JWT_ENCODING_ALGORITHM = SecurityAlgorithms.HmacSha256Signature;
        private const string JWT_TYPE = "JWT";
        private const string JWT_SECRET_SEPARATOR = ".";

        private readonly string _secretKey;

        public JwtFactory(string secretKey)
        {
            _secretKey = secretKey ?? throw new ArgumentNullException(nameof(secretKey));
        }

        public string Generate(User user, string deviceId, string userKey, DateTime issuedAt, DateTime expiresAt)
        {
            var secret = GetSecret(userKey);
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var signingCreds = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            
            var header = new JwtHeader(signingCreds);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.NameId, deviceId),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, issuedAt.ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, expiresAt.ToString())
            };
            var payload = new JwtPayload(claims);

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool IsTokenValid(string token, string userKey)
        {
            var secret = GetSecret(userKey);
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));

            var validationParameters = new TokenValidationParameters()
            {
                ValidIssuer = "erbapps.com", // get rid of hard coded value
                IssuerSigningKey = signingKey
            };

            var isValid = new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out SecurityToken validatedToken);

            return validatedToken.ValidTo > DateTime.UtcNow;
        }

        private string GetSecret(string userKey) 
        {
            return _secretKey + JWT_SECRET_SEPARATOR + userKey;
        }
    }
}