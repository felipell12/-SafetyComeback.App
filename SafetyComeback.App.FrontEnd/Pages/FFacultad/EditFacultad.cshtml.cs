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

namespace SafetyComeback.App.FrontEnd.Pages.FFacultad
{
    public class EditFacultadModel : PageModel
    {
        private readonly IRepositorioFacultad _repoFacultad = new RepositorioFacultad(new Persistencia.AppContext());
        public Facultad Facultad {get;set;}
        
        public IActionResult OnGet(int facultadId)
        {
            //buscar la Facultad
            Facultad=_repoFacultad.GetFacultad(facultadId);
            if (Facultad==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(Facultad facultad)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Facultad=_repoFacultad.UpdateFacultad(facultad);
            TempData["mensaje"]="Facultad modificada exitosamente";
            return RedirectToPage("./ListFacultades");
        }
    }
}
