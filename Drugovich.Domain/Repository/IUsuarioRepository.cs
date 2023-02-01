using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Repository;

namespace Drugovich.Domain.Repository
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> BuscarPorLogin(string login, string password);
    }
}
