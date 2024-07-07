using System.Net;
using APIConsumoExterno.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }
        /// <summary>
        /// Busca todos endereços cadastrados CEP sistema Nacional
        /// </summary>
        /// <returns>200 Sucesso</returns>
        /// <returns>404 Erro</returns>
        [HttpGet("{cep}")]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
        {
            var response = await _enderecoService.BuscarEndereco(cep);
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);

            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }

        }
    }
}