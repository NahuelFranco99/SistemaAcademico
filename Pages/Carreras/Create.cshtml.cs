using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Carreras

{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Carrera.Id = DatosCompartidos.ObtenerNuevoId();

            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("Index");
        }
    }
}