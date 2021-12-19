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
    public class CreateProfesorModel : PageModel
    {
        private readonly IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        public Profesor Profesor {get;set;}
        
        //Http POST Crear profesor
        public IActionResult OnPost(Profesor profesor)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Profesor=_repoProfesor.AddProfesor(profesor);
            TempData["mensaje"]="Profesor creado exitosamente";
            return RedirectToPage("./ListProfesores");

        }
    }
}
