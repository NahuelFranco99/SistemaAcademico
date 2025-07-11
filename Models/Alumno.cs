using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El DNI es obligatorio")]
        public int? Dni { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaDeNacimiento { get; set; }

    }
}
