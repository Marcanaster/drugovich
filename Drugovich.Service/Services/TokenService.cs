using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Drugovich.Service.Services
{
    public class TokenService : ITokenService
    {
        public object GerarToken(UsuarioEntity usuario)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var handler = new JwtSecurityTokenHandler();
            var Key = Encoding.ASCII.GetBytes(configuration.GetRequiredSection("JWT:Secret").Value.ToString());
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Gerente.Nome ),
                    new Claim(ClaimTypes.Role,usuario.Gerente.Nivel.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = configuration.GetRequiredSection("JWT:ValidIssuer").Value.ToString(),
                Audience = configuration.GetRequiredSection("JWT:ValidAudience").Value.ToString(),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(Key), SecurityAlgorithms.HmacSha256Signature)
            };

            var securityToken = handler.CreateToken(tokenDescriptor);
            var token = handler.WriteToken(securityToken);

            DateTime createDate = DateTime.Now;
            DateTime expirationDate = createDate + TimeSpan.FromSeconds(2);

            return SuccessObject(createDate, expirationDate, token, usuario.Gerente.Nome);
        }

        private object SuccessObject(DateTime createDate, DateTime expirationDate, string token, string nome)
        {
            return new
            {
                authenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                acessToken = token,
                userName = nome,
                message = "Usuário logado com sucesso!"
            };
        }
    }
}
