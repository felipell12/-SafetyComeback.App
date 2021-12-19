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

namespace SafetyComeback.App.FrontEnd.Pages.FAforo
{
    public class EditAforoClaseModel : PageModel
    {
        private readonly IRepositorioAforoClase _repoAforoClase = new RepositorioAforoClase(new Persistencia.AppContext());
        public AforoClase AforoClase {get;set;}
        
        public IActionResult OnGet(int aforoClaseId)
        {
            //buscar la Sede
            AforoClase=_repoAforoClase.GetAforoClase(aforoClaseId);
            if (AforoClase==null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(AforoClase aforoClase)
        {
            //identificador_clase=aforoClase.ClaseId;
            this.AforoClase=aforoClase;
            Persona asistente = _repoAforoClase.GetPersona(aforoClase.PersonaId);
            if (asistente!=null)
            {
                if (asistente.Estado_COVID==0)
                {
                    TempData["mensaje"]="Asistente restringido por Positivo para COVID";
                    return Page();
                }
                else
                {
                    if(!ModelState.IsValid)
                    {
                        return Page();
                    }
                    AforoClase=_repoAforoClase.UpdateAforoClase(aforoClase);
                    TempData["mensaje"]="Registro de asistencia modificado exitosamente";
                    return RedirectToPage("./ListAforoClases", new {claseId = AforoClase.ClaseId});
                }
            }
            else
            {
                TempData["mensaje"]="Asistente no existe, digite otro ID";
                return Page();
            }


        }
    }
}
