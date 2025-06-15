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
        public static List<Carrera> listaCarreras = new List<Carrera>();
        //public List<string> Modalidades { get; set; } = new();
        private static int ultimoId = 0;
        public void OnGet()
        {
            //Modalidades = OpcionesModalidad.Lista;
        }
        public IActionResult OnPost()
        {
            ultimoId++;
            Carrera.Id = ultimoId;
            listaCarreras.Add(Carrera);
            DatosCompartidos.Carreras.Add(Carrera);
            return RedirectToPage("Index");
        }
        //    public IActionResult OnPost()
        //    {

        //        //Modalidades = OpcionesModalidad.Lista;
        //        //if (!ModelState.IsValid)
        //        //{
        //        //    return Page();
        //        //}
        //        //ServicioCarrera.AgregarCarrera(Carrera);
        //        return RedirectToPage("Index");
        //    }
    }
}