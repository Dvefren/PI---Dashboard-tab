using System.Collections.Generic;

namespace Dashboards.Models.ViewModels
{
    public class DashboardTutoriasVM
    {
        // --- KPI's (Indicadores Rápidos) ---
        public int TotalAlumnos { get; set; }
        public int AlumnosEnRiesgoAlto { get; set; } // El foco rojo
        public int EntrevistasPendientes { get; set; } // Productividad docente
        public double PorcentajeAsistenciaGlobal { get; set; } // Asistencia promedio

        // --- DATOS PARA GRÁFICAS ---

        // Gráfica 1: Motivos de Atención (¿Por qué van al tutor?)
        // Ejes: ["Académico", "Familiar", "Salud", "Económico"]
        public List<string> EtiquetasMotivos { get; set; }
        public List<int> ValoresMotivos { get; set; }

        // Gráfica 2: Riesgo por Carrera (¿Qué carrera tiene más reprobados?)
        public List<string> Carreras { get; set; }
        public List<int> AlumnosEnRiesgoPorCarrera { get; set; }

        public DashboardTutoriasVM()
        {
            EtiquetasMotivos = new List<string>();
            ValoresMotivos = new List<int>();
            Carreras = new List<string>();
            AlumnosEnRiesgoPorCarrera = new List<int>();
        }
    }
}