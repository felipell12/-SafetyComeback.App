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

namespace SafetyComeback.App.FrontEnd.Pages.FClase
{
    public class DetailsClaseModel : PageModel
    {
        private readonly IRepositorioClase _repoClase = new RepositorioClase(new Persistencia.AppContext());
        public Clase Clase {get;set;}
        
        public IActionResult OnGet(int claseId)
        {
            Clase=_repoClase.GetClase(claseId);
            if (Clase==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
