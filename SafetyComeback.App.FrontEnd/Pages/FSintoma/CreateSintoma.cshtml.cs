using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.FrontEnd.Pages.FSintoma
{
    public class CreateSintomaModel : PageModel
    {
        private readonly IRepositorioSintoma _repoSintoma = new RepositorioSintoma(new Persistencia.AppContext());

        public int identificador_persona  {get;set;}
        public Sintoma Sintoma {get;set;}

        public void OnGet(int personaId)
        {
            identificador_persona=personaId;
        }
        
        public IActionResult OnPost(Sintoma sintoma)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Sintoma=_repoSintoma.AddSintoma(sintoma);
            TempData["mensaje"]="Síntoma creado exitosamente";
            return RedirectToPage("./ListSintoma",new {personaId = sintoma.PersonaId});

        }
    }
}
