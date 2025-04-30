using System.ComponentModel.DataAnnotations;

namespace VargasM_Taller2.Models
{
    public class Reporte
    {
        [Key]
        public int Id { get; set; }
        public List<Jugador> TopGoleadores { get; set; }
        public List<Jugador> TopAsistentes { get; set; }
        public List<Equipo> TopEquiposPresupuesto { get; set; }
    }
}
