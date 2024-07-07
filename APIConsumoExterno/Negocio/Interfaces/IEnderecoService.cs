using APIConsumoExterno.Negocio.Dtos;

namespace APIConsumoExterno.Negocio.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);

    }

}