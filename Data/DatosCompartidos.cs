using SistemaAcademico.Models;

namespace SistemaAcademico.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        private static int ultimoId = 0;

        public static int ObtenerNuevoId()
        {
            ultimoId++;
            return ultimoId;
        }
    }
}
