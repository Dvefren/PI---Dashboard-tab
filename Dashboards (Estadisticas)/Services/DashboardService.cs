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
        public List<int> ObtenerDatosRiesgo()
        {
            // Orden: Regular (Verde), Medio (Amarillo), Alto (Rojo)
            return new List<int> { 85, 10, 5 };
        }
    }
}