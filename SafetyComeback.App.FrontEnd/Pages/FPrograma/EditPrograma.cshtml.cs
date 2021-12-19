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
    public class EditProgramaModel : PageModel
    {
        private readonly IRepositorioPrograma _repoPrograma = new RepositorioPrograma(new Persistencia.AppContext());
        public Programa Programa {get;set;}
        
        public IActionResult OnGet(int programaId)
        {
            //buscar la Programa
            Programa=_repoPrograma.GetPrograma(programaId);
            if (Programa==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(Programa programa)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Programa=_repoPrograma.UpdatePrograma(programa);
            TempData["mensaje"]="Programa modificado exitosamente";
            return RedirectToPage("./ListProgramas");
        }
    }
}
