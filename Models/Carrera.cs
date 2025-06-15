namespace SistemaAcademico.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public int DuracionAnios { get; set; }

        public string? TituloOtorgado { get; set; }

        public string? Modalidad { get; set; } //presencial, virtual, hibrida
    }
}
