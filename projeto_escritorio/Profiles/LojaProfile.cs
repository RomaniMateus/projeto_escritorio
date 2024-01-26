using AutoMapper;
using projeto_escritorio.Data.Dtos;
using projeto_escritorio.Models;

namespace projeto_escritorio.Profiles;

public class LojaProfile : Profile
{
    public LojaProfile()
    {
        CreateMap<CreateLojaDto, Loja>();
        CreateMap<Loja, ReadLojaDto>();
        CreateMap<UpdateLojaDto, Loja>();
    }
}
