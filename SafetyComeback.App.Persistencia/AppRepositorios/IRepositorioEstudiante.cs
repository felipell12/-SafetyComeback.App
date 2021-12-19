using System.Collections.Generic;
//using System.Web.WebPages.Html;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Estudiante
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
        IEnumerable<Estudiante> GetAllEstudiantes();
        Estudiante AddEstudiante(Estudiante estudiante);
        Estudiante UpdateEstudiante(Estudiante estudiante);
        void DeleteEstudiante(int idEstudiante);
        Estudiante GetEstudiante(int idEstudiante);
        IEnumerable<Estudiante> GetAllEstudiantesSearch(string filtro);
       // List<SelectListItem> IRepositorioEstudiante.GetListaEstadosCovid();
    }
}