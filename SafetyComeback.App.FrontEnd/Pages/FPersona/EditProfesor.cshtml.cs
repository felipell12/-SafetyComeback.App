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
    public class EditProfesorModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        public Profesor Profesor {get;set;}
        
        public IActionResult OnGet(int profesorId)
        {
            //buscar la Profesor
            Profesor=_repoProfesor.GetProfesor(profesorId);
            if (Profesor==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(Profesor profesor)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Profesor=_repoProfesor.UpdateProfesor(profesor);
            TempData["mensaje"]="Profesor modificado exitosamente";
            return RedirectToPage("./ListProfesores");
        }
    }
}
