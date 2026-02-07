using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardCalificacionesVM
    {
        // --- KPIs (Indicadores Clave) ---
        public double PromedioGeneral { get; set; }
        public double IndiceAprobacion { get; set; } // Ej. 85% de alumnos pasan
        public int TotalExamenesAplicados { get; set; }
        public int AlumnosEnExtraordinario { get; set; }

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: Top 5 Materias con más reprobados (El "Paredón")
        public List<string> MateriasDificiles { get; set; }
        public List<int> CantidadReprobados { get; set; }

        // Gráfica 2: Distribución de Calificaciones (Histograma)
        // Ejes: ["10", "9", "8", "7", "Reprobado"]
        public List<string> EtiquetasDistribucion { get; set; }
        public List<int> ValoresDistribucion { get; set; }

        public DashboardCalificacionesVM()
        {
            MateriasDificiles = new List<string>();
            CantidadReprobados = new List<int>();
            EtiquetasDistribucion = new List<string>();
            ValoresDistribucion = new List<int>();
        }
    }
}