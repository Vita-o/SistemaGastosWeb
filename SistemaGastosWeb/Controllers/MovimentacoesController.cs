using Microsoft.AspNetCore.Mvc;
using SistemaGastosWeb.Data;
using SistemaGastosWeb.Models;

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

            ViewBag.TotalGanho = movimentacoes.Where(x => x.Tipo == "Ganho").Sum(x => x.Valor);

            ViewBag.TotalGasto = movimentacoes.Where(x => x.Tipo == "Gasto").Sum(x => x.Valor);

            ViewBag.Saldo = ViewBag.TotalGanho - ViewBag.Gasto;

            return View(movimentacoes);
        }

        [HttpGet]
        public IActionResult Criar(string tipo = "Gasto")
        {
            var model = new MovimentacoesModel
            {
                Tipo = tipo,
                Data = DateTime.Now
            };

            ViewBag.TituloTela = tipo == "Ganho" ? "Novo Ganho" : "Novo Gasto";
            return View(model);
        }
    }
}
