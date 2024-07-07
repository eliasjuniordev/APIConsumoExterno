using APIConsumoExterno.Negocio.Dtos;
using APIConsumoExterno.Negocio.Model.Models;
using AutoMapper;

namespace APIConsumoExterno.Data.Mappings.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}