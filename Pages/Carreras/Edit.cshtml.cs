using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Data;
using SistemaAcademico.Models;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }

        public void OnGet(int id)
        {
            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == id)
                {
                    Carrera = c;
                    break;
                }
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Actualizar la carrera en la lista
            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == Carrera.Id)
                {
                    c.Nombre = Carrera.Nombre;
                    c.DuracionAnios = Carrera.DuracionAnios;
                    c.TituloOtorgado = Carrera.TituloOtorgado;
                    c.Modalidad = Carrera.Modalidad;
                    break;
                }
            }
            return RedirectToPage("Index");
        }
    }
}

