using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VargasM_Taller2.Data;
using VargasM_Taller2.Models;

namespace VargasM_Taller2.Controllers
{
    public class ReporteController : Controller
    {
        private readonly VargasM_Taller2Context _context;

        public ReporteController(VargasM_Taller2Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var topGoleadores = _context.Jugador
                .Include(j => j.Equipo)
                .OrderByDescending(j => j.Goles)
            .Take(5)
                .ToList();

            var topAsistentes = _context.Jugador
                .Include(j => j.Equipo)
                .OrderByDescending(j => j.Asistencias)
            .Take(5)
                .ToList();


            var topEquiposPresupuesto = _context.Equipo
                .OrderByDescending(e => e.Presupuesto)
                .Take(5)
                .ToList();

            ActualizarPresupuesto();

            var reporte = new Reporte
            {
                TopGoleadores = topGoleadores,
                TopAsistentes = topAsistentes,
                TopEquiposPresupuesto = topEquiposPresupuesto
            };

            return View(reporte);
        }

        private void ActualizarPresupuesto()
        {
            var equipos = _context.Equipo.Include(e => e.Jugadores).ToList();

            foreach (var equipo in equipos)
            {
                equipo.Presupuesto = equipo.Jugadores.Sum(j => j.Sueldo);
            }

            _context.SaveChanges();
        }
    }
}
