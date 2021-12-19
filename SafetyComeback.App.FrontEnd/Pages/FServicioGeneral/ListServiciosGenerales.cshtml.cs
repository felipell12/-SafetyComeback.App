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

namespace SafetyComeback.App.FrontEnd.Pages.FServicioGeneral
{
    [Authorize]
    public class ListServiciosGeneralesModel : PageModel
    {
        
        private readonly IRepositorioServicioGeneral _repoServicioGeneral = new RepositorioServicioGeneral(new Persistencia.AppContext());
        
        public IEnumerable<ServicioGeneral> listServiciosGenerales {get;set;}
        
        public string FiltroSearch { get;set;}
        
        public void OnGet(string filtroSearch)
        {
           // listServiciosGenerales =_repoServicioGeneral.GetAllServiciosGenerales();
           FiltroSearch=filtroSearch;
           listServiciosGenerales = _repoServicioGeneral.GetAllServiciosGeneralesSearch(filtroSearch);
        }
    }
}

