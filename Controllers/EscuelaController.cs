using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_MVC.Models;
using System;
using System.Linq;

namespace ASP.NET_Core_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Elemento1 = "Prueba de texto";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context){
            _context = context;
        }
    }
}