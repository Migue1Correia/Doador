using Doador.domain.Command;
using Doador.domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _ProdutoService;
        public ProdutoController(IProdutoService ProdutoService)
        {
            _ProdutoService = ProdutoService;
        }
        [HttpPost]
        [Route("CadastrarProduto")]
        public async Task<IActionResult> PostAsync([FromBody] ProdutoCommand command)

        {
            return Ok(await _ProdutoService.PostAsync(command));
        }
    }
}
