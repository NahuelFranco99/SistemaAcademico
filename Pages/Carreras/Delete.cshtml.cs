using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Repositorios;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }

        private readonly ServicioCarrera servicio;

        public DeleteModel()
        {
            servicio = new ServicioCarrera();
        }

        public IActionResult OnGet(int id)
        {
            var carrera = servicio.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("Index");
            }
            Carrera = carrera;
            return Page();
        }

        public IActionResult OnPost()
        {
            servicio.Agregar(Carrera);
            return RedirectToPage("Index");
        }
    }
}
