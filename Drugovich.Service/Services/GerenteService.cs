using AutoMapper;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Repository;
using Drugovich.Domain.Interfaces.Services;

namespace Drugovich.Service.Services
{
    public class GerenteService : IGerenteService
    {
        private IRepository<GerenteEntity> _repository;
        private IMapper _mapper;

        public GerenteService(IRepository<GerenteEntity> repository,  IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<GerenteEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<GerenteEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<GerenteEntity> Create(GerenteDto gerente)
        {
            var entity = _mapper.Map<GerenteEntity>(gerente);
            return await _repository.InsertAsync(entity);
        }

        public async Task<GerenteEntity> Update(GerenteDto gerente)
        {
            var entity = _mapper.Map<GerenteEntity>(gerente);
            return await _repository.UpdateAsync(entity);
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
