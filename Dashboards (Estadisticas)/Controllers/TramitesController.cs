using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class TramitesController : Controller
    {
        private readonly DashboardService _service;

        public TramitesController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.ObtenerDatosTramites();
            if (modelo == null) modelo = new DashboardTramitesVM();
            return View(modelo);
        }
    }
}