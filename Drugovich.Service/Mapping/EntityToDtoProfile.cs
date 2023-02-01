using AutoMapper;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Entities;

namespace Drugovich.Service.Mapping
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<ClienteEntity, ClienteDto>().ReverseMap();
            CreateMap<GerenteEntity, GerenteDto>().ReverseMap();
            CreateMap<GrupoEntity, GrupoDto>().ReverseMap();

        }
        
    }
}
