using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class InscripcionesController : Controller
    {
        private readonly DashboardService _service;

        public InscripcionesController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.ObtenerDatosInscripciones();
            if (modelo == null) modelo = new DashboardInscripcionesVM();
            return View(modelo);
        }
    }
}