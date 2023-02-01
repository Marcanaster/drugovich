using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;

namespace Drugovich.Domain.Interfaces.Services
{
    public interface IGrupoService
    {
        Task<GrupoEntity> Get(int id);
        Task<IEnumerable<GrupoEntity>> GetAll();
        Task<GrupoEntity> Create(GrupoDto grupo);
        Task<GrupoEntity> Update(GrupoDto grupo);
        Task<bool> Delete(int id);
    }
}
