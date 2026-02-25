using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardInscripcionesVM
    {
        // --- KPIs ---
        public int MetaNuevosIngresos { get; set; }
        public int FichasVendidas { get; set; }
        public int InscritosReales { get; set; }
        public double PorcentajeCumplimiento { get; set; }

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: El Embudo (Fichas -> Examen -> Aceptados -> Inscritos)
        public List<string> EtiquetasEmbudo { get; set; }
        public List<int> ValoresEmbudo { get; set; }

        // Gráfica 2: Inscritos por Carrera
        public List<string> EtiquetasCarreras { get; set; }
        public List<int> ValoresInscritos { get; set; }

        public DashboardInscripcionesVM()
        {
            EtiquetasEmbudo = new List<string>();
            ValoresEmbudo = new List<int>();
            EtiquetasCarreras = new List<string>();
            ValoresInscritos = new List<int>();
        }
    }
}