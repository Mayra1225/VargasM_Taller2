using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VargasM_Taller2.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Nombre del equipo")]
        public string Nombre { get; set; }
        public string LogoUrl { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 100)]
        public int Puntos => (PartidosGanados * 3) + PartidosEmpatados;
        public string Ciudad { get; set; }
        public string DT { get; set; }
        public string Estadio { get; set; }
    }
}