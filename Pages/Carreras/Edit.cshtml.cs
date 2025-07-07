using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaAcademico.Helpers;
using SistemaAcademico.Models;
using SistemaAcademico.Servicios;

namespace SistemaAcademico.Pages.Carreras
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Carrera Carrera { get; set; }
        public List<string> Modalidades { get; set; } = new();

        public void OnGet(int id)
        {
            Modalidades = OpcionesModalidad.Lista;

            Carrera? carrera = ServicioCarrera.BuscarPorId(id);
            if (carrera == null)
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
            
            ServicioCarrera.EditarCarrera(Carrera);
            return RedirectToPage("Index");
        }
    }
}