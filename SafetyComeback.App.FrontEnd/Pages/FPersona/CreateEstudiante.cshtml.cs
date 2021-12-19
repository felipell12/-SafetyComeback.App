using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.FrontEnd.Pages.FPersona
{
    public class CreateEstudianteModel : PageModel
    {
        private readonly IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        public Estudiante Estudiante {get;set;}
      //  public List<SelectListItem> listaEstadosCovid {get;set;}

        //Http GET Listar estudiantes
        /*public void OnGet(int idtemp)
        {
             Console.WriteLine("Entro a GET");
             this.listaEstadosCovid = new List<SelectListItem>();
             this.listaEstadosCovid = GetListaEstadosCovid();
        }*/
        
        //Http POST Crear estudiante
        public IActionResult OnPost(Estudiante estudiante)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Estudiante=_repoEstudiante.AddEstudiante(estudiante);
            TempData["mensaje"]="Estudiante creado exitosamente";
            return RedirectToPage("./ListEstudiantes");

        }

        List<SelectListItem> GetListaEstadosCovid()
        {
            Console.WriteLine("Entro a método");
            return new List<SelectListItem>()
            {
                new SelectListItem(){
                    Text="Positivo",
                    Value="0"
                },
                new SelectListItem(){
                    Text="Negativo",
                    Value="1"
                },
                new SelectListItem(){
                    Text="Sin_prueba",
                    Value="2"
                },
                new SelectListItem(){
                    Text="SD",
                    Value="3"
                }
            };

        }
    }
}
 //@Html.EnumDropDownListFor(model => model.Types, htmlAttributes: new { @class = "form-control" })
//<select asp-for=@Model.Estudiante.Estado_COVID asp-items="Html.GetEnumSelectList<@Model.EstadoCovidList>()"></select> 
// <input class="form-control" asp-for=@Model.Estudiante.Estado_COVID />
