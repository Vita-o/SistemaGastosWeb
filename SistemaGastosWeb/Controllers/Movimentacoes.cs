using Microsoft.AspNetCore.Mvc;
using SistemaGastosWeb.Data;

namespace SistemaGastosWeb.Controllers
{
    public class MovimentacoesController : Controller
    {
        private readonly FinanceiroContext _contexto;

        public MovimentacoesController(FinanceiroContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}