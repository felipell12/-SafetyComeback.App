using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.FrontEnd.Pages.FAforo
{
    [Authorize]
    public class ListAforoClasesModel : PageModel
    {
        
       private readonly IRepositorioAforoClase _repoAforoClase = new RepositorioAforoClase(new Persistencia.AppContext());
        
        public IEnumerable<AforoClase> listAforoClases {get;set;}
        public int identificador_clase  {get;set;}
        public Clase act_clase {get; set;}
        
        
        public void OnGet(int claseId)
        {
            //buscar los asistentes de la clase
            identificador_clase=claseId;
            act_clase=_repoAforoClase.GetClase(claseId);
            listAforoClases =_repoAforoClase.GetAllAforoClase(claseId);
        }

    }
}

