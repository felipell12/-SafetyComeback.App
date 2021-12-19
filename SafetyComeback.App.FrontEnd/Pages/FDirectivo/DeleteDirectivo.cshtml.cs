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
    public class DeleteDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        public Directivo Directivo {get;set;}
        
        public IActionResult OnGet(int directivoId)
        {
            //buscar la Facultad
            Directivo=_repoDirectivo.GetDirectivo(directivoId);
            if (Directivo==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int directivoId)
        {
            Directivo=_repoDirectivo.GetDirectivo(directivoId);
            if (Directivo==null)
            {
                return NotFound();
            }
            _repoDirectivo.DeleteDirectivo(directivoId);
            TempData["mensaje"]="Directivo eliminado exitosamente";
            return RedirectToPage("./ListDirectivos");
        }
    }
}
