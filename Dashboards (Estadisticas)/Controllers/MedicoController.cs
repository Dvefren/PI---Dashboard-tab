using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DashboardService _service;

        public MedicoController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var modelo = _service.ObtenerDatosMedicos();
            if (modelo == null) modelo = new DashboardMedicoVM();
            return View(modelo);
        }
    }
}