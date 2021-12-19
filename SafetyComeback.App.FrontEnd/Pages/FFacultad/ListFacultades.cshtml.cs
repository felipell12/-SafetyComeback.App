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

namespace SafetyComeback.App.FrontEnd.Pages.FFacultad
{
    [Authorize]
    public class ListFacultadesModel : PageModel
    {
        
        private readonly IRepositorioFacultad _repoFacultad = new RepositorioFacultad(new Persistencia.AppContext());
        
        //private readonly IRepositorioFacultad repositorioFacultad;
        public IEnumerable<Facultad> listFacultades {get;set;}
        
        
        /*public ListFacultadesModel(IRepositorioFacultad _repoFacultad)
        public ListFacultadesModel()
        {
            //this._repoFacultad=_repoFacultad;
        }*/

        public void OnGet()
        {
            listFacultades =_repoFacultad.GetAllFacultades();
        }
    }
}

