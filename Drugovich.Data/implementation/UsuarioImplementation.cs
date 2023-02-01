using Drugovich.Data.Context;
using Drugovich.Data.Repository;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.Data.implementation
{
    public  class UsuarioImplementation : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private DbSet<UsuarioEntity> _dataSet;
        public UsuarioImplementation(DrugovichContext context) : base(context)
        {
            _dataSet = context.Set<UsuarioEntity>();
        }

        public async Task<UsuarioEntity> BuscarPorLogin(string login, string password)
        {
            return await _dataSet.Include(g => g.Gerente).FirstOrDefaultAsync(u => u.Login.Equals(login) && u.Senha.Equals(password));
        }
    }
}
