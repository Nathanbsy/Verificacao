using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VerificacaoRotinas.Models;
using VerificacaoRotinas.Repositorio;

namespace VerificacaoRotinas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRotinaRepositorio _rotinaRepositorio;

        public HomeController(ILogger<HomeController> logger, IRotinaRepositorio rotinaRepositorio)
        {
            _logger = logger;
            _rotinaRepositorio = rotinaRepositorio;
        }

        public IActionResult Index()
        {
            string caminho = Path.Combine(Directory.GetCurrentDirectory(), "Txt", "rotinas.txt");
            var teste = _rotinaRepositorio.LerTxt(caminho);
            return View(_rotinaRepositorio.LerTxt(caminho));
        }
    }
}
