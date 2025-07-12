using SistemaAcademico.AccesoAdatos;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SistemaAcademico.Pages.Alumnos

{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Alumno Alumno { get; set; }

        private readonly ServicioAlumno servicio;
        public CreateModel()
        {
            IAccesoDatos<Alumno> acceso = new AccesoDatosJson<Alumno>("alumnos");
            IRepositorio<Alumno> repo = new RepositorioCrudJson<Alumno>(acceso);
            servicio = new ServicioAlumno(repo);
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            servicio.Agregar(Alumno);

            return RedirectToPage("Index");
        }
    }
}