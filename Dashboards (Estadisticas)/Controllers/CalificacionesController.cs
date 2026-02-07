using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class CalificacionesController : Controller
    {
        private readonly DashboardService _service;

        public CalificacionesController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.ObtenerDatosCalificaciones();
            if (modelo == null) modelo = new DashboardCalificacionesVM();
            return View(modelo);
        }
    }
}