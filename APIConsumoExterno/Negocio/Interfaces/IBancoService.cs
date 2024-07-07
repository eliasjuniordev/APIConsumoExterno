using APIConsumoExterno.Negocio.Dtos;

namespace APIConsumoExterno.Negocio.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(int codigoBanco);
    }
}
