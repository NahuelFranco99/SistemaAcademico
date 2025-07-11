using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;

namespace SistemaAcademico.Servicios
{
    public class ServicioAlumno
    {
        private readonly IRepositorio<Alumno> _repo;
        public ServicioAlumno(IRepositorio<Alumno> repo)
        {
            _repo = repo;
        }
        public List<Alumno> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }
        public Alumno? BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
        public void Agregar(Alumno alumno)
        {
            _repo.Agregar(alumno);
        }
        public void Editar(Alumno alumno)
        {
            _repo.Editar(alumno);
        }
        public void EliminarPorId(int id)
        {
            _repo.EliminarPorId(id);
        }
    }
}
