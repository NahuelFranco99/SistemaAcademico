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
    }
}
