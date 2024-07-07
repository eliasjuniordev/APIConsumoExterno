using IntegraBrasilApi.Dtos;

namespace APIConsumoExterno.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(int codigoBanco);
    }
}
