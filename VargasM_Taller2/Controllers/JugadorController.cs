using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VargasM_Taller2.Data;
using VargasM_Taller2.Models;

namespace VargasM_Taller2.Controllers
{
    public class JugadorController : Controller
    {
        private readonly VargasM_Taller2Context _context;

        public JugadorController(VargasM_Taller2Context context)
        {
            _context = context;
        }

        private void ActualizarPresupuesto(int equipoId)
        {
            var equipo = _context.Equipo.Include(e => e.Jugadores)
                                           .FirstOrDefault(e => e.Id == equipoId);

            if (equipo != null)
            {
                equipo.Presupuesto = equipo.Jugadores.Sum(j => j.Sueldo);
                _context.SaveChanges();
            }
        }

        // GET: Jugador
        public async Task<IActionResult> Index(int? equipoId)
        {
            var jugadores = _context.Jugador.Include(j => j.Equipo).AsQueryable();

            var equipos = await _context.Equipo.ToListAsync();
            ViewBag.Equipos = new SelectList(equipos, "Id", "Nombre");

            if (equipoId.HasValue)
            {
                jugadores = jugadores.Where(j => j.EquipoId == equipoId);
            }

            jugadores = jugadores.OrderByDescending(j => j.Goles);

            return View(await jugadores.ToListAsync());
        }

        // GET: Jugador/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador
                .Include(j => j.Equipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // GET: Jugador/Create
        public IActionResult Create()
        {
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre");
            return View();
        }

        // POST: Jugador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,NumeroCamiseta,Goles,Asistencias,Sueldo,EquipoId")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jugador);
                await _context.SaveChangesAsync();
                ActualizarPresupuesto(jugador.EquipoId);
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", jugador.EquipoId);
            return View(jugador);
        }

        // GET: Jugador/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", jugador.EquipoId);
            return View(jugador);
        }

        // POST: Jugador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,NumeroCamiseta,Goles,Asistencias,Sueldo,EquipoId")] Jugador jugador)
        {
            if (id != jugador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jugador);
                    ActualizarPresupuesto(jugador.EquipoId);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JugadorExists(jugador.Id))
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
            ViewData["EquipoId"] = new SelectList(_context.Equipo, "Id", "Nombre", jugador.EquipoId);
            return View(jugador);
        }

        // GET: Jugador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jugador = await _context.Jugador
                .Include(j => j.Equipo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jugador == null)
            {
                return NotFound();
            }

            return View(jugador);
        }

        // POST: Jugador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jugador = await _context.Jugador.FindAsync(id);
            if (jugador != null)
            {
                _context.Jugador.Remove(jugador);
                ActualizarPresupuesto(jugador.EquipoId);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugador.Any(e => e.Id == id);
        }
    }
}
