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

            CreateMap<CaoFatura, CaoFaturaDTO>().ReverseMap();
            CreateMap<CaoFaturaCreateDTO, CaoFatura>().ReverseMap();
            CreateMap<CaoFaturaUpdateDTO, CaoFatura>().ReverseMap();
            CreateMap<CaoFaturaDeleteDTO, CaoFatura>().ReverseMap();

            CreateMap<CaoSalario, CaoSalarioDTO>().ReverseMap();
            CreateMap<CaoSalarioCreateDTO, CaoSalario>().ReverseMap();
            CreateMap<CaoSalarioUpdateDTO, CaoSalario>().ReverseMap();
            CreateMap<CaoSalarioDeleteDTO, CaoSalario>().ReverseMap();
        }
    }
}
