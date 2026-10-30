using Microsoft.AspNetCore.Mvc;
using SistemaGastosWeb.Data;

namespace SistemaGastosWeb.Controllers
{
    public class MovimentacoesController : Controller
    {
        private readonly FinanceiroContext _context;

        public MovimentacoesController(FinanceiroContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movimentacoes = _context.Movimentacoes.ToList();

            return View(movimentacoes);
        }
    }
}