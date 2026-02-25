using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardMedicoVM
    {
        // --- KPIs (Indicadores Diarios) ---
        public int ConsultasHoy { get; set; }
        public int CasosPsicologia { get; set; }
        public int TrasladosEmergencia { get; set; }
        public int MedicamentosEntregados { get; set; }

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: Top 5 Diagnósticos (¿De qué se enferman más?)
        public List<string> EtiquetasDiagnosticos { get; set; }
        public List<int> ValoresDiagnosticos { get; set; }

        // Gráfica 2: Consultas Médicas vs Psicológicas (Dona)
        public List<string> EtiquetasAreas { get; set; }
        public List<int> ValoresAreas { get; set; }

        public DashboardMedicoVM()
        {
            EtiquetasDiagnosticos = new List<string>();
            ValoresDiagnosticos = new List<int>();
            EtiquetasAreas = new List<string>();
            ValoresAreas = new List<int>();
        }
    }
}