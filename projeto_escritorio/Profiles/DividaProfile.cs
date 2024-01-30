using AutoMapper;
using projeto_escritorio.Data.Dtos;
using projeto_escritorio.Models;

namespace projeto_escritorio.Profiles;

public class DividaProfile : Profile
{
    public DividaProfile()
    {
        CreateMap<CreateDividaDto, Divida>();
        CreateMap<Divida, ReadDividaDto>();
    }
}
