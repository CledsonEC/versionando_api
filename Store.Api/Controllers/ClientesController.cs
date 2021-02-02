using Microsoft.AspNetCore.Mvc;
using Store.Api.Model;
using System;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    public class ClientesController : ControllerBase
    {
        [HttpGet("{clienteId}")]
        public IActionResult ObterClienteV1([FromRoute] Guid clienteId)
        {
            var cliente = new ClienteModel
            {
                Id = clienteId,
                Nome = "Nome do Cliente"
            };

            return Ok(cliente);
        }

        [HttpGet("{clienteId}")]
        [MapToApiVersion("2.0")]
        public IActionResult ObterClienteV2([FromRoute] Guid clienteId)
        {
            var cliente = new ClienteModelV2
            {
                Id = clienteId,
                Nome = "Nome do Cliente v2",
                Idade = 19
            };

            return Ok(cliente);
        }
    }
}

