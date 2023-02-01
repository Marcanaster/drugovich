using Drugovich.Domain.Entities;

namespace Drugovich.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        object GerarToken(UsuarioEntity usuario);
    }
}
