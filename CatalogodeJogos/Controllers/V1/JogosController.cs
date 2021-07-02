using CatalogodeJogos.InputModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogodeJogos.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {
            return Ok();
        }

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<List<object>>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost]

        public async Task<ActionResult<object>> InserirJogo(JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")]

        public async Task<ActionResult<object>> AtualizarJogo(Guid idJogo, JogoInputModel jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]

        public async Task<ActionResult<object>> AtualizarJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]

        public async Task<AcceptedResult> ApagarJogo(Guid IdJogo)
        {
            return Ok();
        }

    }
}
}
