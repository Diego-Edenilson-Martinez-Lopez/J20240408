
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace J20240408.EntidadesDeNegocio
{
    public class PersonaJ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreJ { get; set; }

        [Required]
        [StringLength(50)]
        public string ApellidoJ { get; set; }

        [Required]

        public DateTime FechadeNacimientoJ { get; set; }

        [Required]
        public decimal SueldoJ { get; set; }


        [Required(ErrorMessage = "El estatus  es requerido.")]
        public byte Estatus { get; set; }
    }
}
