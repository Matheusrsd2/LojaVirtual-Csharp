using Ecommerce.Libraries.Email;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
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

        public IActionResult ContatoAcao()
        {
            try
            {
            Contato contato = new Contato();
            contato.Nome = HttpContext.Request.Form["nome"];
            contato.Email = HttpContext.Request.Form["email"];
            contato.Texto = HttpContext.Request.Form["texto"];

            //ContatoEmail.EnviarContatoPorEmail(contato);
            ViewData["MSG_S"] = "Mensagem enviada com sucesso";
            }
            catch(Exception e)
            {
                ViewData["MSG_E"] = "Ops! Houve um erro ao tentar enviar";
            }
            return View("Contato");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
