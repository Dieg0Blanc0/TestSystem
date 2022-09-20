using AutoMapper;
using TestSystem.Core.DTOs;
using TestSystem.Core.Entities;

namespace TestSystem.Infrastructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CaoUsuario, CaoUsuarioDTO>().ReverseMap();
            CreateMap<CaoUsuarioCreateDTO, CaoUsuario>().ReverseMap();
            CreateMap<CaoUsuarioUpdateDTO, CaoUsuario>().ReverseMap();
            CreateMap<CaoUsuarioDeleteDTO, CaoUsuario>().ReverseMap();
        }
    }
}
