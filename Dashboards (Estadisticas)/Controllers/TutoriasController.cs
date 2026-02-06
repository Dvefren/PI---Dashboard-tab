using Microsoft.AspNetCore.Mvc;
using Dashboards.Services; // Usamos el servicio
using Dashboards.Models.ViewModels;

namespace Dashboards.Controllers
{
    public class TutoriasController : Controller
    {
        private readonly DashboardService _service;

        public TutoriasController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            // 1. Pedimos los datos específicos de Tutorías
            var modelo = _service.ObtenerDatosTutorias();

            // 2. Protección contra nulos
            if (modelo == null) modelo = new DashboardTutoriasVM();

            return View(modelo);
        }
    }
}