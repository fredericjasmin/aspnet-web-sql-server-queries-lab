using System;
using Microsoft.AspNetCore.Mvc;
using ConsultasWeb.Models;
using System.Threading.Tasks;

namespace ConsultasWeb.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly DatabaseHelper _dbHelper;

        public ConsultasController(DatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        // Mostrar la vista con botones
        public IActionResult Index()
        {
            return View();
        }
        // Acción para consulta 1
        [HttpPost]
        public async Task<IActionResult> Consulta1(int parametro)
        {
            var resultado = await _dbHelper.Consulta1Async(parametro);
            return View("Resultado", resultado);
        }

        // Acción para consulta 2
        [HttpPost]
        public async Task<IActionResult> Consulta2(string parametro)
        {
            var resultado = await _dbHelper.Consulta2Async(parametro);
            return View("Resultado", resultado);
        }

        // Acción para consulta 3
        [HttpPost]
        public async Task<IActionResult> Consulta3(string parametro)
        {
            if (DateTime.TryParse(parametro, out DateTime fecha))
            {
                var resultado = await _dbHelper.Consulta3Async(fecha);
                return View("Resultado", resultado);
            }
            else
            {
                ViewBag.Error = "Fecha inválida";
                return View("Index");
            }
        }
    }
}
