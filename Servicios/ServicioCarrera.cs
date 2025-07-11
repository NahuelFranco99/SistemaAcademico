using System.Text.Json;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;

namespace SistemaAcademico.Servicios
{
    public class ServicioCarrera
    {

        private readonly IRepositorio<Carrera> _repo;
        public ServicioCarrera(IRepositorio<Carrera> repo)
        {
            _repo = repo;
        }
        public List<Carrera> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }
        public Carrera? BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
        public void Agregar(Carrera carrera)
        {
            _repo.Agregar(carrera);
        }
        public void Editar(Carrera carrera)
        {
            _repo.Editar(carrera);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }

        //public static string LeerTextoDelArchivo()
        //{
        //    if (File.Exists(ruta))
        //    {
        //        return File.ReadAllText(ruta);
        //    }
        //    return "[]";
        //}
        //public static List<Carrera> ObtenerCarreras()
        //{
        //    string json = LeerTextoDelArchivo();

        //    var lista = JsonSerializer.Deserialize<List<Carrera>>(json);
        //    return lista ?? new List<Carrera>();

        //}
        //public static void AgregarCarrera(Carrera nuevaCarrera)
        //{
        //    var carreras = ObtenerCarreras();
        //    nuevaCarrera.Id = ObtenerNuevoId(carreras);
        //    carreras.Add(nuevaCarrera);
        //    GuardarCarreras(carreras);
        //}

        //public static int ObtenerNuevoId(List<Carrera> carreras)
        //{
        //    int maxId = 0;

        //    foreach (var carrera in carreras)
        //    {
        //        if (carrera.Id > maxId)
        //        {
        //            maxId = carrera.Id;
        //        }
        //    }
        //    return maxId+1;
        //}
        //public static void GuardarCarreras(List<Carrera> carreras)
        //{
        //    string textoJson = JsonSerializer.Serialize(carreras);
        //    File.WriteAllText(ruta, textoJson);
        //}
        //public static Carrera? BuscarPorId(int id)
        //{
        //    var lista = ObtenerCarreras();
        //    return BuscarCarreraPorId(lista, id);
        //}

        //public static void EliminarPorId(int id)
        //{
        //    var lista = ObtenerCarreras();
        //    var carrera = BuscarCarreraPorId(lista, id);

        //    if (carrera != null)
        //    {
        //        lista.Remove(carrera);
        //        GuardarCarreras(lista);
        //    }
        //}

        //public static void EditarCarrera(Carrera carreraEditada)
        //{
        //    var lista = ObtenerCarreras();
        //    var carrera = BuscarCarreraPorId(lista, carreraEditada.Id);

        //    if (carrera != null)
        //    {
        //        carrera.Nombre = carreraEditada.Nombre;
        //        carrera.DuracionAnios = carreraEditada.DuracionAnios;
        //        carrera.TituloOtorgado = carreraEditada.TituloOtorgado;
        //        carrera.Modalidad = carreraEditada.Modalidad;
        //        GuardarCarreras(lista);
        //    }
        //}
        //private static Carrera? BuscarCarreraPorId(List<Carrera> lista, int id)
        //{
        //    foreach (var carrera in lista)
        //    {
        //        if (carrera.Id == id)
        //        {
        //            return carrera;
        //        }
        //    }
        //    return null;
        //}
    }
}
