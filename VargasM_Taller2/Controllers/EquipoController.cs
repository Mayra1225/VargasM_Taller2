using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VargasM_Taller2.Data;
using VargasM_Taller2.Models;
using VargasM_Taller2.Repositories;

namespace VargasM_Taller2.Controllers
{
    public class EquipoController : Controller
    {
        private readonly VargasM_Taller2Context _context;
        public EquipoRepository _repository;


        // GET: Equipo
        public EquipoController(VargasM_Taller2Context context)
        {
            _context = context;
            _repository = new EquipoRepository();
        }
        public async Task<IActionResult> Index()
        {
            if (!_context.Equipo.Any())
            {
                var equiposDesdeMemoria = _repository.DevuelveListadoEquipos();
                _context.Equipo.AddRange(equiposDesdeMemoria);
                await _context.SaveChangesAsync();
            }

            var equiposEnBD = await _context.Equipo.ToListAsync();
            var equiposn = equiposEnBD.OrderByDescending(item => item.Puntos);
            ActualizarPresupuesto();

            return View(equiposn);
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

        // GET: Equipo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // GET: Equipo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,LogoUrl,PartidosJugados,PartidosGanados,PartidosEmpatados,PartidosPerdidos,Ciudad,DT,Estadio")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipo);
        }

        // GET: Equipo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var equipo = await _context.Equipo.FindAsync(id);
            if (equipo == null)
            {
                return NotFound();
            }*/

            var equipo = await _context.Equipo
                .Include(e => e.Jugadores) // 👈 Incluimos la propiedad de navegación
        .       FirstOrDefaultAsync(e => e.Id == id);

            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,LogoUrl,PartidosJugados,PartidosGanados,PartidosEmpatados,PartidosPerdidos,Ciudad,DT,Estadio")] Equipo equipo)
        {
            if (id != equipo.Id)
            {
                return NotFound();
            }

            try
            {
                var equipoExistente = await _context.Equipo.FindAsync(id);

                // Solo actualiza los campos deseados
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;

                _context.Update(equipoExistente);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoExists(equipo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Equipo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipo = await _context.Equipo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }

        // POST: Equipo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipo = await _context.Equipo.FindAsync(id);
            if (equipo != null)
            {
                _context.Equipo.Remove(equipo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipo.Any(e => e.Id == id);
        }
    }
}
