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
    public class CreateAforoClaseModel : PageModel
    {
        private readonly IRepositorioAforoClase _repoAforoClase = new RepositorioAforoClase(new Persistencia.AppContext());

        [BindProperty]
        public int identificador_clase  {get;set;}
        public AforoClase AforoClase {get;set;}

        public void OnGet(int claseId)
        {
            identificador_clase=claseId;
        }
        
        public IActionResult OnPost(AforoClase aforoClase)
        {
            identificador_clase=aforoClase.ClaseId;
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
                    AforoClase=_repoAforoClase.AddAforoClase(aforoClase);
                    TempData["mensaje"]="Asistente registrado en la clase exitosamente";
                    return RedirectToPage("./ListAforoClases",new {claseId = aforoClase.ClaseId});
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
