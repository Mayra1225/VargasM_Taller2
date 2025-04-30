using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VargasM_Taller2.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0, 100)]

        public int NumeroCamiseta { get; set; }
        [Range(0, 100)]

        public int Goles { get; set; }
        [Range(0, 100)]
        public int Asistencias { get; set; }

        [DataType(DataType.Currency)]
        [Range(0.0, 10000.0, ErrorMessage = "El saldo debe estar entre 0 y 10,000")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal Sueldo { get; set; }
        

        // Relación con Equipo
        public int EquipoId { get; set; }
        [ForeignKey("EquipoId")]
        public Equipo? Equipo { get; set; }
    }

}
