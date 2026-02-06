namespace Dashboards.Models.ViewModels
{
    public class DashboardVM
    {
        // --- SECCIÓN 1: INDICADORES PRINCIPALES ---
        public int TotalAlumnos { get; set; }
        public double PromedioGeneral { get; set; }
        public int AlumnosEnRiesgo { get; set; }
        public int TramitesPendientes { get; set; }

        // --- AGREGA ESTA LÍNEA QUE FALTABA: ---
        public int NuevosIngresos { get; set; }

        // --- SECCIÓN 2: DATOS PARA LAS GRÁFICAS ---
        public List<string> EtiquetasCarreras { get; set; }
        public List<int> ValoresPoblacion { get; set; }
        public List<int> ValoresRiesgo { get; set; }

        public DashboardVM()
        {
            EtiquetasCarreras = new List<string>();
            ValoresPoblacion = new List<int>();
            ValoresRiesgo = new List<int>();
        }
    }
}