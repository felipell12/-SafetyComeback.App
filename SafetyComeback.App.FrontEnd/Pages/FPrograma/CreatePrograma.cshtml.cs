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

namespace SafetyComeback.App.FrontEnd.Pages.FPrograma
{
    public class CreateProgramaModel : PageModel
    {
        private readonly IRepositorioPrograma _repoPrograma = new RepositorioPrograma(new Persistencia.AppContext());
        public Programa Programa {get;set;}
        
        public IActionResult OnPost(Programa programa)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Programa=_repoPrograma.AddPrograma(programa);
            TempData["mensaje"]="Programa creado exitosamente";
            return RedirectToPage("./ListProgramas");

        }
    }
}
