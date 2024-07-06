using System.Diagnostics;
using System.Net;
using APIConsumoExterno.Interfaces;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;

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
    }
}