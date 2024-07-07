using APIConsumoExterno.Negocio.Dtos;
using APIConsumoExterno.Negocio.Interfaces;
using AutoMapper;
using System.Runtime.ConstrainedExecution;

namespace IntegraBrasilApi.Services
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public BancoService(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos()
        {
            var Banco = await _brasilApi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(Banco);
        }

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(int codigoBanco)
        {
            var Banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(Banco);
        }
    }
}