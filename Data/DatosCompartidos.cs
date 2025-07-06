using SistemaAcademico.Models;
using SistemaAcademico.Helpers;
using System.Text.Json;
using SistemaAcademico.Servicios;
using static SistemaAcademico.Servicios.ServicioCarrera;

namespace SistemaAcademico.Data
{
    public class DatosCompartidos
    {
        public static List<Carrera> Carreras { get; set; } = new();
        private static int ultimoId = 0;

        public static int ObtenerNuevoId(List<Carrera>carreras)
        {
            int maxId = 0;

            foreach (var carrera in carreras)
            {
                if (carrera.Id > maxId)
                {
                    maxId = carrera.Id;
                }
            }
            return maxId+1;
        }
        public static void GuardarCarreras(List<Carrera> carreras)
        {
            string textoJson = JsonSerializer.Serialize(carreras);
            File.WriteAllText(ruta, textoJson);
        }
    }
}
