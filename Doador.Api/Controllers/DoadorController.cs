using Doador.domain.Command;
using Doador.domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doador.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _DoadorService;
        public DoadorController(IDoadorService DoadorService)
        {
            _DoadorService = DoadorService;
        }
        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync([FromBody] DoadorCommand command)
        {
            return Ok(await _DoadorService.PostAsync(command));
        }
    }
}
