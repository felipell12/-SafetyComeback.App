using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.FrontEnd.Pages.FPersona
{
    public class DeleteProfesorModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        public Profesor Profesor {get;set;}
        
        public IActionResult OnGet(int profesorId)
        {
            //buscar la Facultad
            Profesor=_repoProfesor.GetProfesor(profesorId);
            if (Profesor==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int profesorId)
        {
            Profesor=_repoProfesor.GetProfesor(profesorId);
            if (Profesor==null)
            {
                return NotFound();
            }
            _repoProfesor.DeleteProfesor(profesorId);
            TempData["mensaje"]="Profesor eliminado exitosamente";
            return RedirectToPage("./ListProfesores");
        }
    }
}
