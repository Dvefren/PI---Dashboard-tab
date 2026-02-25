using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardTramitesVM
    {
        // --- KPIs ---
        public int SolicitudesNuevas { get; set; }
        public int TramitesEnProceso { get; set; }
        public double TiempoRespuestaPromedio { get; set; } // En días
        public double IngresosMensuales { get; set; } // Dinero recaudado

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: Trámites más solicitados
        public List<string> EtiquetasTiposTramite { get; set; }
        public List<int> ValoresTiposTramite { get; set; }

        // Gráfica 2: Semáforo de tiempos (A tiempo vs Retrasados)
        public List<string> EtiquetasEstatus { get; set; }
        public List<int> ValoresEstatus { get; set; }

        public DashboardTramitesVM()
        {
            EtiquetasTiposTramite = new List<string>();
            ValoresTiposTramite = new List<int>();
            EtiquetasEstatus = new List<string>();
            ValoresEstatus = new List<int>();
        }
    }
}