using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Programa     
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPrograma
    {
        IEnumerable<Programa> GetAllProgramas();
        Programa AddPrograma(Programa programa);
        Programa UpdatePrograma(Programa programa);
        void DeletePrograma(int idPrograma);
        Programa GetPrograma(int idPrograma);

    }
}