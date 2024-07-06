
using APIConsumoExterno.Interfaces;
using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
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
    }
}