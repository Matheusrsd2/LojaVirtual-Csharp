using LojaVirtualCsharp.Libraries.Email;
using LojaVirtualCsharp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtualCsharp.Database;

namespace LojaVirtualCsharp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
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

        /*******
        /Cadastro de cliente */
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();

                TempData["MSG_S"] = "Cadastro realizado com sucesso";
                return RedirectToAction(nameof(CadastroCliente));
            }
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

            /*var ListaMensagem = new List<ValidationResult>();
            var contexto = new ValidationContext(contato);
            Validator.TryValidateObject(contato,contexto,ListaMensagem);
            if (isValid)
            {

            }*/

            ContatoEmail.EnviarContatoPorEmail(contato);
            ViewData["MSG_S"] = "Mensagem enviada com sucesso";
            }
            catch(System.Exception)
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
