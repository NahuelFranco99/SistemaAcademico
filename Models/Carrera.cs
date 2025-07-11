using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]

        public string Nombre { get; set; }
        [Range(1, 7, ErrorMessage = "Duración entre 1 y 7 años")]

        [Display(Name = "Duración en Años")]
        public int? DuracionAnios { get; set; }
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]

        [Display(Name = "Título otorgado")]
        public string TituloOtorgado { get; set; }

        [StringLength(30, MinimumLength = 5, ErrorMessage = "Debe tener entre 5 y 30 caracteres")]
        public string Modalidad { get; set; }
    }
}