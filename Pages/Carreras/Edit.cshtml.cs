using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.AccesoAdatos;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new();

        private readonly ServicioCarrera servicio;
        public EditModel()
        {
            IAccesoDatos<Carrera> acceso = new AccesoDatosJson<Carrera>("carreras");
            IRepositorio<Carrera> repo = new RepositorioCrudJson<Carrera>(acceso);
            servicio = new ServicioCarrera(repo);
        }
        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            Carrera carrera = servicio.BuscarPorId(id);
            if (carrera != null)
            {
                Carrera = carrera;
            }
        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            servicio.Editar(Carrera);

            return RedirectToPage("Index");
        }
    }
}
