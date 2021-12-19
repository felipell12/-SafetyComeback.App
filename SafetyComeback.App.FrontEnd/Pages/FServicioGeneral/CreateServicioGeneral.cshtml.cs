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

namespace SafetyComeback.App.FrontEnd.Pages.FServicioGeneral
{
    public class CreateServicioGeneralModel : PageModel
    {
        private readonly IRepositorioServicioGeneral _repoServicioGeneral = new RepositorioServicioGeneral(new Persistencia.AppContext());
        public ServicioGeneral ServicioGeneral {get;set;}
        
        //Http POST Crear servicioGeneral
        public IActionResult OnPost(ServicioGeneral servicioGeneral)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            ServicioGeneral=_repoServicioGeneral.AddServicioGeneral(servicioGeneral);
            TempData["mensaje"]="Servicio General creado exitosamente";
            return RedirectToPage("./ListServiciosGenerales");

        }
    }
}
