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
    public class DetailsFacultadModel : PageModel
    {
        private readonly IRepositorioFacultad _repoFacultad = new RepositorioFacultad(new Persistencia.AppContext());
        public Facultad Facultad {get;set;}
        
        public IActionResult OnGet(int facultadId)
        {
            Facultad=_repoFacultad.GetFacultad(facultadId);
            if (Facultad==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
