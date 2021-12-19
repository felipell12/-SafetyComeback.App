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
    public class DeleteSalonModel : PageModel
    {
        private readonly IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        public Salon Salon {get;set;}
        
        public IActionResult OnGet(int salonId)
        {
            //buscar la Salon
            Salon=_repoSalon.GetSalon(salonId);
            if (Salon==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int salonId)
        {
            Salon=_repoSalon.GetSalon(salonId);
            if (Salon==null)
            {
                return NotFound();
            }
            _repoSalon.DeleteSalon(salonId);
            TempData["mensaje"]="Salón eliminado exitosamente";
            return RedirectToPage("./ListSalones");
        }
    }
}
