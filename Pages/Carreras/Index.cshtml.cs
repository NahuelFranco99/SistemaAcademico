using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoAdatos;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras
{
    public class IndexModel : PageModel
    {
        public List<Carrera> Carreras { get; set; }

        private readonly ServicioCarrera servicio;
        public IndexModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("carreras");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);
        }
        public void OnGet()
        {
            Carreras = servicio.ObtenerTodos();
        }
    }
}