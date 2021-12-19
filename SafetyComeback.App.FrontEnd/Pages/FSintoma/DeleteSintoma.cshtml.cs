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
    public class DeleteSintomaModel : PageModel
    {
        private readonly IRepositorioSintoma _repoSintoma = new RepositorioSintoma(new Persistencia.AppContext());
        public Sintoma Sintoma {get;set;}
        
        public IActionResult OnGet(int sintomaId)
        {
            //buscar la Sede
            Sintoma=_repoSintoma.GetSintoma(sintomaId);
            if (Sintoma==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int sintomaId)
        {
            Sintoma=_repoSintoma.GetSintoma(sintomaId);
            if (Sintoma==null)
            {
                return NotFound();
            }
            _repoSintoma.DeleteSintoma(sintomaId);
            TempData["mensaje"]="Sintoma eliminada exitosamente";
            return RedirectToPage("./ListSintoma");
        }
    }
}
