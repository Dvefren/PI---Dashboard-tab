using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class VinculacionController : Controller
    {
        private readonly DashboardService _service;

        public VinculacionController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.ObtenerDatosVinculacion();
            if (modelo == null) modelo = new DashboardVinculacionVM();
            return View(modelo);
        }
    }
}