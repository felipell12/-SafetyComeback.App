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

namespace SafetyComeback.App.FrontEnd.Pages.FDirectivo
{
    public class CreateDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        public Directivo Directivo {get;set;}
        
        //Http POST Crear directivo
        public IActionResult OnPost(Directivo directivo)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Directivo=_repoDirectivo.AddDirectivo(directivo);
            TempData["mensaje"]="Directivo creado exitosamente";
            return RedirectToPage("./ListDirectivos");

        }
    }
}
