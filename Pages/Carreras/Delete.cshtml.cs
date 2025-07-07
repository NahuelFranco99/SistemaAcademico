using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }

        public IActionResult OnGet(int id)
        {
            var carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera == null)
            {
                return RedirectToPage("Index");
            }
            Carrera = carrera;
            return Page();

        }
        public IActionResult OnPost()
        {
            ServicioCarrera.EliminarPorId(Carrera.Id);
            return RedirectToPage("Index");
        }
    }
}
