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

namespace SafetyComeback.App.FrontEnd.Pages.FPrograma
{
    [Authorize]
    public class ListProgramasModel : PageModel
    {
        
        private readonly IRepositorioPrograma _repoPrograma = new RepositorioPrograma(new Persistencia.AppContext());
        
        //private readonly IRepositorioPrograma repositorioPrograma;
        public IEnumerable<Programa> listProgramas {get;set;}
        
        
        /*public ListProgramasModel(IRepositorioPrograma _repoPrograma)
        public ListProgramasModel()
        {
            //this._repoPrograma=_repoPrograma;
        }*/

        public void OnGet()
        {
            listProgramas =_repoPrograma.GetAllProgramas();
        }
    }
}

