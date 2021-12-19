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

namespace SafetyComeback.App.FrontEnd.Pages.FSalon
{
    public class CreateSalonModel : PageModel
    {
        private readonly IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        public Salon Salon {get;set;}
        
        public IActionResult OnPost(Salon salon)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Salon=_repoSalon.AddSalon(salon);
            TempData["mensaje"]="Salón creado exitosamente";
            return RedirectToPage("./ListSalones");

        }
    }
}
