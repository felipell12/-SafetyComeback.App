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
    public class DeleteEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public Estudiante Estudiante {get;set;}
        
        public IActionResult OnGet(int estudianteId)
        {
            //buscar la Facultad
            Estudiante=_repoEstudiante.GetEstudiante(estudianteId);
            if (Estudiante==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int estudianteId)
        {
            Estudiante=_repoEstudiante.GetEstudiante(estudianteId);
            if (Estudiante==null)
            {
                return NotFound();
            }
            _repoEstudiante.DeleteEstudiante(estudianteId);
            TempData["mensaje"]="Estudiante eliminado exitosamente";
            return RedirectToPage("./ListEstudiantes");
        }
    }
}
