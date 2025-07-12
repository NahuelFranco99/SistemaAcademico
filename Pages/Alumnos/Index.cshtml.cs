using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoAdatos;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;


namespace SistemaAcademico.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        public List<Alumno> Alumnos { get; set; }

        private readonly ServicioAlumno servicio;
        public IndexModel()
        {
            IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("alumnos");
            IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
            servicio = new ServicioAlumno(repo);
        }
        public void OnGet()
        {
            Alumnos = servicio.ObtenerTodos();
        }
    }
}