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

namespace SafetyComeback.App.FrontEnd.Pages.FSede
{
    public class CreateSedeModel : PageModel
    {
        private readonly IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        public Sede Sede {get;set;}
        
        public IActionResult OnPost(Sede sede)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Sede=_repoSede.AddSede(sede);
            TempData["mensaje"]="Sede creada exitosamente";
            return RedirectToPage("./ListSedes");

        }
    }
}
