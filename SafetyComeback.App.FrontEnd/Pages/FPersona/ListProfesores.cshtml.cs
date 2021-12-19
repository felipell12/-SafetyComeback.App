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

namespace SafetyComeback.App.FrontEnd.Pages.FPersona
{
    [Authorize]
    public class ListProfesoresModel : PageModel
    {
        
        private readonly IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        
        public IEnumerable<Profesor> listProfesores {get;set;}

        public string FiltroSearch { get;set;}
        
        
        //Http GET Listar profesores
        public void OnGet(string filtroSearch)
        {
           // listProfesores =_repoProfesor.GetAllProfesores();
            FiltroSearch=filtroSearch;
            listProfesores=_repoProfesor.GetAllProfesoresSearch(filtroSearch);
        }

    }
}

