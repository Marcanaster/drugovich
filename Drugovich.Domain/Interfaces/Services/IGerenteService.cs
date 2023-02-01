using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;

namespace Drugovich.Domain.Interfaces.Services
{
    public interface IGerenteService
    {
        Task<GerenteEntity> Get(int id);
        Task<IEnumerable<GerenteEntity>> GetAll();
        Task<GerenteEntity> Create(GerenteDto gerente);
        Task<GerenteEntity> Update(GerenteDto gerente);
        Task<bool> Delete(int id);
    }
}
