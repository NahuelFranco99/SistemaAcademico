using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombrees obligatorio")]

        public int DuracionAnios { get; set; }
        [Range(1, 10, ErrorMessage = "Duración entre 1 y 10 años")]

        public string TituloOtorgado { get; set; }
        [Display(Name = "Título otorgado")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 20 caracteres")]

        public string Modalidad { get; set; }
    }
}