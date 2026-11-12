using Microsoft.AspNetCore.Mvc;

namespace SistemaGastosWeb.Controllers
{
    public class LoginController : Controller
    {
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
            return View(); // Abre a View Views/Login/Cadastro.cshtml
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
        public IActionResult Cadastrar(string nome, string email, string senha)
        {
            // Lógica de salvar o utilizador virá aqui no futuro
            return RedirectToAction("Index");
        }
    }
}