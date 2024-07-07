using APIConsumoExterno.Negocio.Dtos;
using APIConsumoExterno.Negocio.Model.Models;
using AutoMapper;

namespace APIConsumoExterno.Data.Mappings.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap<BancoModel, BancoResponse>();
            CreateMap<ResponseGenerico<List<BancoModel>>, ResponseGenerico<List<BancoResponse>>>()
                .ForMember(dest => dest.DadosRetorno, opt => opt.MapFrom(src => src.DadosRetorno));
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}