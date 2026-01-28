using Microsoft.AspNetCore.Mvc;

namespace Dashboards.Controllers // Asegúrate que el namespace coincida con tu proyecto
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Este "return View()" busca automáticamente un archivo en:
            // Views/Dashboard/Index.cshtml
            return View();
        }
    }
}