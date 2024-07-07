using APIConsumoExterno.Negocio.Dtos;
using APIConsumoExterno.Negocio.Model.Models;

namespace APIConsumoExterno.Negocio.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);
        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(int codigoBanco);

    }

}