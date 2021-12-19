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
    public class ListEstudiantesModel : PageModel
    {
        
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        
        public IEnumerable<Estudiante> listEstudiantes {get;set;}

        public string FiltroSearch { get;set;}

        //Http GET Listar estudiantes
        public void OnGet(string filtroSearch)
        {
            //listEstudiantes =_repoEstudiante.GetAllEstudiantes();
            FiltroSearch=filtroSearch;
            listEstudiantes=_repoEstudiante.GetAllEstudiantesSearch(filtroSearch);
        }
       
    }
}

