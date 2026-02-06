using Microsoft.AspNetCore.Mvc;
using Dashboards.Services;       // Necesario para conectar con el Servicio
using Dashboards.Models.ViewModels; // Necesario para entender los datos

namespace Dashboards.Controllers // <--- Asegúrate que esto coincida con tu proyecto (DashboardsApp o similar)
{
    public class DashboardController : Controller
    {
        private readonly DashboardService _service;

        // CONSTRUCTOR: Aquí recibimos el servicio (Inyección de Dependencias)
        public DashboardController(DashboardService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            // PASO 1: Pedimos los datos al servicio
            var modelo = _service.ObtenerResumenGeneral();

            // PASO 2: Verificamos que no sean nulos (Protección extra)
            if (modelo == null)
            {
                // Si el servicio falló, creamos un modelo vacío para que no truene
                modelo = new DashboardVM();
            }

            // PASO 3: Enviamos los datos a la vista
            return View(modelo); // <--- ¡AQUÍ ESTABA EL ERROR! Seguramente tenías View() vacío.
        }
    }
}