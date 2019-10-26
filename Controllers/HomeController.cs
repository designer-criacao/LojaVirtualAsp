using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;
using Loja.Libraries.Email;
using System.ComponentModel.DataAnnotations;

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
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if(isValid)
                {
                    ContatoEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }
                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["Contato"] = contato;
                }

            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";

                //TODO - Implementar Log
            }
            
            return View("Contato");
            //return new ContentResult() { Content = string.Format("Dados recebidos com sucesso!<br /> Nome: {0} <br />E-mail: {1} <br />Texto: {2}", contato.Nome, contato.Email, contato.Texto), ContentType = "text/html" };
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