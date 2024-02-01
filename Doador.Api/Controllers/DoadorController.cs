using Microsoft.AspNetCore.Mvc;

namespace Doador.Api.Controllers
{
    public class DoadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
