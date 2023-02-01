using AutoMapper;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;
using Drugovich.Domain.Interfaces.Repository;
using Drugovich.Domain.Interfaces.Services;

namespace Drugovich.Service.Services
{
    internal class GrupoService : IGrupoService
    {
        private IRepository<GrupoEntity> _repository;
        private IMapper _mapper;

        public GrupoService(IRepository<GrupoEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<GrupoEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<GrupoEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<GrupoEntity> Create(GrupoDto grupo)
        {
            var entity = _mapper.Map<GrupoEntity>(grupo);
            return await _repository.InsertAsync(entity);
        }

        public async Task<GrupoEntity> Update(GrupoDto grupo)
        {
            var entity = _mapper.Map<GrupoEntity>(grupo);
            return await _repository.UpdateAsync(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
