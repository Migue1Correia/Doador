using Microsoft.AspNetCore.Mvc;

namespace Doador.Api.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
