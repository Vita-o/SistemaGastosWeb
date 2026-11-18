using Microsoft.AspNetCore.Mvc;
using SistemaGastosWeb.Data;
using SistemaGastosWeb.Models;
using System.Linq;

namespace SistemaGastosWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly FinanceiroContext _context;

        public LoginController(FinanceiroContext context)
        {
            _context = context;
        }  



        // GET: /Login (ou /Login/Index)
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Abre a View Views/Login/Index.cshtml
        }

        // GET: /Login/Cadastro
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View(); 
        }

        // POST: /Login/Entrar
        [HttpPost]
        public IActionResult Entrar(string email, string senha)
        {
            // Lógica de autenticação virá aqui no futuro
            return RedirectToAction("Index", "Home");
        }

        // POST: /Login/Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            if (usuario.Nome == null) 
            {
                ViewBag.Erro = "Falta Campo a ser Preenchido ";
                return View("Cadastro");
            } else if (_context.Usuario.any())
            {

            }


            return RedirectToAction("Index");
        }
    }
}