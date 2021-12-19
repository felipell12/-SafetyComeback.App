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

namespace SafetyComeback.App.FrontEnd.Pages.FClase
{
    [Authorize]
    public class ListClasesModel : PageModel
    {
        
        private readonly IRepositorioClase _repoClase = new RepositorioClase(new Persistencia.AppContext());
        
        public IEnumerable<Clase> listClases {get;set;}
        
        
        public void OnGet()
        {
            listClases =_repoClase.GetAllClases();
        }
    }
}

