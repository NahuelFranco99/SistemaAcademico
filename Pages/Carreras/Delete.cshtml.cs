using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Models;
using SistemaAcademico.Data;

namespace SistemaAcademico.Pages.Carreras
{
    public class DeleteModel : PageModel
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
            Carrera carreraElminar = null;

            foreach (var c in DatosCompartidos.Carreras)
            {
                if (c.Id == Carrera.Id)
                {
                    carreraElminar = c;
                    break;
                }
            }
            if (carreraElminar != null)
            {
                DatosCompartidos.Carreras.Remove(carreraElminar);
            }
            return RedirectToPage("Index");
        }
    }
}
