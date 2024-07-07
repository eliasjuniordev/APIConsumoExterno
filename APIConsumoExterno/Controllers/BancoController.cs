using System.Diagnostics;
using System.Net;
using APIConsumoExterno.Interfaces;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace IntegraBrasilApi.controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }



        /// <summary>
        /// Busca todos os Bancos Sistemas Financeiro Nacional
        /// </summary>
        /// <returns>200 Sucesso</returns>
        /// <returns>404 Erro</returns>
        [HttpGet("")]
        public async Task<IActionResult> BuscarTodosBancos()
        {
            var response = await _bancoService.BuscarTodosBancos();
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);

            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }

        }
        /// <summary>
        /// Busca  Banco Sistema Financeiro Nacional
        /// </summary>
        /// <returns>200 Sucesso</returns>
        /// <returns>404 Erro</returns>
        [HttpGet("{code}")]
        public async Task<IActionResult> BuscarBanco([FromRoute] int code)
        {
            var response = await _bancoService.BuscarBanco(code);
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