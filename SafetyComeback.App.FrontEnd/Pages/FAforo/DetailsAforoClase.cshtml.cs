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

namespace SafetyComeback.App.FrontEnd.Pages.FAforo
{
    public class DetailsAforoClaseModel : PageModel
    {
        private readonly IRepositorioAforoClase _repoAforoClase = new RepositorioAforoClase(new Persistencia.AppContext());
        public AforoClase AforoClase {get;set;}
        
        public IActionResult OnGet(int aforoClaseId)
        {
            AforoClase=_repoAforoClase.GetAforoClase(aforoClaseId);
            if (AforoClase==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}
