using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.FrontEnd.Pages.FSalon
{
    [Authorize]
    public class ListSalonesModel : PageModel
    {
        
        private readonly IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
        
        public IEnumerable<Salon> listSalones {get;set;}
        
        
        public void OnGet()
        {
            listSalones =_repoSalon.GetAllSalones();
        }
    }
}

