using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardVinculacionVM
    {
        // --- KPIs ---
        public int AlumnosEnEstadias { get; set; }
        public int AlumnosEnServicio { get; set; }
        public int EmpresasConvenio { get; set; }
        public double PorcentajeContratacion { get; set; } // Alumnos contratados donde hicieron estadía

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: Top Empresas Receptoras
        public List<string> EtiquetasEmpresas { get; set; }
        public List<int> ValoresAlumnosPorEmpresa { get; set; }

        // Gráfica 2: Alumnos por Modalidad (Dona)
        public List<string> EtiquetasModalidad { get; set; }
        public List<int> ValoresModalidad { get; set; }

        public DashboardVinculacionVM()
        {
            EtiquetasEmpresas = new List<string>();
            ValoresAlumnosPorEmpresa = new List<int>();
            EtiquetasModalidad = new List<string>();
            ValoresModalidad = new List<int>();
        }
    }
}