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
        [DataType(DataType.Currency)]
        [Range(0.0, 10000.0, ErrorMessage = "El saldo debe estar entre 0 y 10,000")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal Presupuesto { get; set; }

        public virtual ICollection<Jugador>? Jugadores { get; set; }
    }
}