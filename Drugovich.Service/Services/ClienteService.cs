using AutoMapper;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Repository;
using Drugovich.Domain.Interfaces.Services;

namespace Drugovich.Service.Services
{
    public class ClienteService : IClienteService
    {
        private IRepository<ClienteEntity> _repository;
        private IMapper _mapper;

        public ClienteService(IRepository<ClienteEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ClienteEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<ClienteEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ClienteEntity> Create(ClienteDto cliente)
        {
            var entity = _mapper.Map<ClienteEntity>(cliente);
            return await _repository.InsertAsync(entity);
        }

        public async Task<ClienteEntity> Update(ClienteDto cliente)
        {
            var entity = _mapper.Map<ClienteEntity>(cliente);
            return await _repository.UpdateAsync(entity);
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
