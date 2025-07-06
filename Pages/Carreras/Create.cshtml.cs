using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras

{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }

        public List<string> Modalidades { get; set; } = new();

        public void OnGet()
        {
            Modalidades = OpcionesModalidad.Lista;
        }
        public IActionResult OnPost()
        {
            Modalidades = OpcionesModalidad.Lista;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}