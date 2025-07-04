using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]

        public int DuracionAnios { get; set; }
        [Required]

        public string TituloOtorgado { get; set; }
        [Required]

        public string Modalidad { get; set; }
    }
}
