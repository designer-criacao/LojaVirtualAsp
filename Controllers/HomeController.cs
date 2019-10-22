using Microsoft.AspNetCore.Mvc;

namespace Loja.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContatoAcao()
        {
            return new ContentResult() { Content = "Dados recebidos com sucesso!" };
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}