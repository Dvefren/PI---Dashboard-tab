using Dashboards.Models.ViewModels;
using System.Collections.Generic;

namespace Dashboards.Services
{
    public class DashboardService
    {
        // CONSTRUCTOR: Aquí inyectaremos el DbContext (La conexión a SQL) en el futuro
        // private readonly ApplicationDbContext _context;
        // public DashboardService(ApplicationDbContext context) { _context = context; }

        /// <summary>
        /// Obtiene los KPIs principales para las tarjetas de arriba (Rectoría).
        /// </summary>
        public DashboardVM ObtenerResumenGeneral()
        {
            // --- ZONA DE SIMULACIÓN (MOCK DATA) ---
            // Aquí inventamos los datos para que el Frontend pueda trabajar
            // mientras esperas que te den acceso a la Base de Datos real.

            var datosSimulados = new DashboardVM
            {
                TotalAlumnos = 2450,        // Dato estático por ahora
                EtiquetasCarreras = new List<string> { "Mecatrónica", "Sistemas", "Mantenimiento", "Procesos" },
                ValoresPoblacion = new List<int> { 120, 190, 85, 60 },
                ValoresRiesgo = new List<int> { 85, 10, 5 }
            };

            return datosSimulados;

            // --- ZONA REAL (FUTURO) ---
            // Cuando tengas SQL, borrarás lo de arriba y pondrás algo así:
            /*
            return new DashboardVM
            {
                TotalAlumnos = _context.Alumnos.Count(a => a.Activo == true),
                PromedioGeneral = _context.Calificaciones.Average(c => c.Valor),
                // etc...
            };
            */
        }

        /// <summary>
        /// Devuelve los datos para la gráfica de Barras (Alumnos por Carrera).
        /// </summary>
        public List<int> ObtenerDatosPoblacion()
        {
            // Orden: Mecatrónica, Sistemas, Mantenimiento, Procesos, Admin, Renovables
            return new List<int> { 450, 320, 280, 200, 150, 120 };
        }

        /// <summary>
        /// Devuelve las etiquetas para la gráfica de Barras.
        /// </summary>
        public List<string> ObtenerNombresCarreras()
        {
            return new List<string> { "Mecatrónica", "Sistemas", "Mantenimiento", "Procesos", "Administración", "Renovables" };
        }

        /// <summary>
        /// Devuelve los datos para la gráfica de Dona (Riesgo).
        /// </summary>
        public DashboardTutoriasVM ObtenerDatosTutorias()
        {
            // SIMULACIÓN DE LÓGICA DE NEGOCIO (BACKEND)
            // Aquí es donde en el futuro harás las consultas complejas a SQL.

            var modelo = new DashboardTutoriasVM
            {
                // 1. KPIs Generales
                TotalAlumnos = 2450,
                AlumnosEnRiesgoAlto = 125, // Esto debería preocupar al Rector
                EntrevistasPendientes = 45,
                PorcentajeAsistenciaGlobal = 92.5,

                // 2. Datos para Gráfica de Motivos
                EtiquetasMotivos = new List<string> { "Reprobación", "Problemas Familiares", "Ansiedad/Estrés", "Económico" },
                ValoresMotivos = new List<int> { 120, 45, 30, 15 },
                // Nota: El backend calcula que "Reprobación" es el problema #1

                // 3. Datos para Gráfica de Riesgo por Carrera
                Carreras = new List<string> { "Mecatrónica", "Sistemas", "Procesos", "Mantenimiento" },
                AlumnosEnRiesgoPorCarrera = new List<int> { 40, 25, 35, 25 }
            };

            return modelo;
        }
    }

}