using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Profesor
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioProfesor
    {
        IEnumerable<Profesor> GetAllProfesores();
        Profesor AddProfesor(Profesor profesor);
        Profesor UpdateProfesor(Profesor profesor);
        void DeleteProfesor(int profesor);
        Profesor GetProfesor(int idProfesor);
        IEnumerable<Profesor> GetAllProfesoresSearch(string filtro);
    }
}