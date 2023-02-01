using Drugovich.Domain.Dtos;

namespace Drugovich.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        Task<object> AutenticarUsuario(LoginDto login);
    }
}
