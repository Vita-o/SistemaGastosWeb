using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaGastosWeb.Models;
using SistemaGastosWeb.Data;


namespace SistemaGastosWeb.Controllers
{
    public class GanhoDiarioController : Controller
    {

        private readonly FinanceiroContext _context;

        public GanhoDiarioController(FinanceiroContext Context)
        {
            _context = Context;
        }

        public async Task<IActionResult> Index()
        {
            var ganhos = await _context.GanhoDiario.ToListAsync();
            return View(ganhos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(GanhoDiarioModel ganho)
        {
            if (ModelState.IsValid)
            {
                _context.GanhoDiario.Add(ganho);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ganho);


        }
    }
}
