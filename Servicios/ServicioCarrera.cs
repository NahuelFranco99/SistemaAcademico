using SistemaAcademico.Models;
using System.Text.Json;
using SistemaAcademico.Helpers;
using SistemaAcademico.Servicios;
using static SistemaAcademico.Data.DatosCompartidos;

namespace SistemaAcademico.Servicios
{
    public static class ServicioCarrera
    {
        public static string ruta = "Data/carreras.json";

        public static string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return "[]";
        }
        public static List<Carrera> ObtenerCarreras()
        {
            string json = LeerTextoDelArchivo();

            var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
            return lista ?? new List<Carrera>();

        }
        public static void AgregarCarrera(Carrera nuevaCarrera)
        {
            var carreras = ObtenerCarreras();
            nuevaCarrera.Id = ObtenerNuevoId(carreras);
            carreras.Add(nuevaCarrera);
            GuardarCarreras(carreras);
        }
    }
}
