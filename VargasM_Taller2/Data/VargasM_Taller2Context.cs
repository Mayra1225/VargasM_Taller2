using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VargasM_Taller2.Models;

namespace VargasM_Taller2.Data
{
    public class VargasM_Taller2Context : DbContext
    {
        public VargasM_Taller2Context (DbContextOptions<VargasM_Taller2Context> options)
            : base(options)
        {
        }

        public DbSet<VargasM_Taller2.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<VargasM_Taller2.Models.Jugador> Jugador { get; set; } = default!;
    }
}
