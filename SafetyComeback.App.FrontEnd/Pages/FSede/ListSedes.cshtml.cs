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

namespace SafetyComeback.App.FrontEnd.Pages.FSede
{
    [Authorize]
    public class ListSedesModel : PageModel
    {
        
        private readonly IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        
        public IEnumerable<Sede> listSedes {get;set;}
        
        
        public void OnGet()
        {
            listSedes =_repoSede.GetAllSedes();
        }
    }
}

