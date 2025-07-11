using System.Text.Json;

namespace SistemaAcademico.AccesoAdatos
{
    public class AccesoDatosJson <T> : IAccesoDatos<T> 
    {
        private string ruta;

        public AccesoDatosJson(string nombreArchivo)
        {
         ruta = $"Data/{nombreArchivo}.json";
        }

        private string LeerTextoDelArchivo()
        {
            if (File.Exists(ruta))
            {
                return File.ReadAllText(ruta);
            }
            return "[]";
        }

        public List<T> Leer()
        {
            string json = LeerTextoDelArchivo();
            var lista = JsonSerializer.Deserialize<List<T>>(json);
            return lista ?? new List<T>();
        }

        public void Guardar(List<T> lista)
        {
            string textoJson = JsonSerializer.Serialize(lista);
            File.WriteAllText(ruta, textoJson);
        }

    }
}
