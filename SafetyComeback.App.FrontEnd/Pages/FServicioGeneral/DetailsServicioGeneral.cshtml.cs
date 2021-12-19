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

namespace SafetyComeback.App.FrontEnd.Pages.FServicioGeneral
{
    public class DetailsServicioGeneralModel : PageModel
    {
        private readonly IRepositorioServicioGeneral _repoServicioGeneral = new RepositorioServicioGeneral(new Persistencia.AppContext());
        public ServicioGeneral ServicioGeneral {get;set;}
        
        public IActionResult OnGet(int servicioGeneralId)
        {
            ServicioGeneral=_repoServicioGeneral.GetServicioGeneral(servicioGeneralId);
            if (ServicioGeneral==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
