using Drugovich.CrossCutting.Help;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Services;
using Drugovich.Domain.Repository;
using Microsoft.Extensions.Configuration;

namespace Drugovich.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUsuarioRepository _repository;
        private ITokenService _service;

        public LoginService(IUsuarioRepository repository, ITokenService service)
        {
            _repository = repository;
            _service = service;
        }

        public async Task<object> AutenticarUsuario(LoginDto login)
        {
            var usuarioBase = new UsuarioEntity();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            if (login != null && !string.IsNullOrWhiteSpace(login.Login) && !string.IsNullOrWhiteSpace(login.Senha))
            {
                var chave = configuration.GetRequiredSection("KEY_CRYPT").Value.ToString();
                var passEncrypt = Crypt.Encrypt(login.Senha, chave);
                usuarioBase = await _repository.BuscarPorLogin(login.Login, passEncrypt);
                if (usuarioBase != null)
                {
                    return _service.GerarToken(usuarioBase);

                }
                else
                {
                    return new { authenticated = false, message = "Falha ao autenticar" };
                }
            }
            else
            {
                return new { authenticated = false, message = "Falha ao autenticar" };
            }
        }
    }
}
