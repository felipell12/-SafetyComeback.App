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

namespace SafetyComeback.App.FrontEnd.Pages.FSintoma
{
    [Authorize]
    public class ListSintomasModel : PageModel
    {
        
        private readonly IRepositorioSintoma _repoSintoma = new RepositorioSintoma(new Persistencia.AppContext());
        
        public IEnumerable<Sintoma> listSintomas {get;set;}
        public int identificador_persona  {get;set;}
        
        
        public void OnGet(int personaId)
        {
            //buscar los sintomas de la persona
            /*Estudiante=_repoEstudiante.GetEstudiante(estudianteId);
            if (Estudiante==null)
            {
                return NotFound();
            }*/
            identificador_persona=personaId;
            listSintomas =_repoSintoma.GetAllSintomas(personaId);
        }
    }
}

