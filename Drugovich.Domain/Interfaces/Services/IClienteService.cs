using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;

namespace Drugovich.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        Task<ClienteEntity> Get(int id);
        Task<IEnumerable<ClienteEntity>> GetAll();
        Task<ClienteEntity> Create(ClienteDto cliente);
        Task<ClienteEntity> Update(ClienteDto cliente);
        Task<bool> Delete(int id);
    }
}
