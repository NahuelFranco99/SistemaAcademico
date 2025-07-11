using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
            servicio = new ServicioCarrera();
        }

        public void OnGet(int id)
        {
            var servicioCarrera = new RepositorioCrudJson<Carrera>("carreras");
            List<Carrera> carreras = servicioCarrera.ObtenerTodos();

            Modalidades = OpcionesModalidad.Lista;

        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Carrera);
            return RedirectToPage("Index");
        }
    }
}