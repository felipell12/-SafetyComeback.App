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

namespace SafetyComeback.App.FrontEnd.Pages.FDirectivo
{
    [Authorize]
    public class ListDirectivosModel : PageModel
    {
        
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        
        public IEnumerable<Directivo> listDirectivos {get;set;}
        
        public string FiltroSearch { get;set;}
        

        public void OnGet(string filtroSearch)
        {
           // listDirectivos =_repoDirectivo.GetAllDirectivos();
            FiltroSearch=filtroSearch;
            listDirectivos=_repoDirectivo.GetAllDirectivosSearch(filtroSearch);
        }
    }
}

