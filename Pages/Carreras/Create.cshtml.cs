using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;

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


            Carrera.Id = DatosCompartidos.ObtenerNuevoId();

            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("Index");
        }
    }
}