using Microsoft.AspNetCore.Mvc.RazorPages;
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
            servicio = new ServicioCarrera();
        }

        public void OnGet()
        {
            var servicioCarrera = new RepositorioCrudJson<Carrera>("carreras");
            List<Carrera> carreras = servicioCarrera.ObtenerTodos();
        }
    }
}