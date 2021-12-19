using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Universidad
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUniversidad
    {
        IEnumerable<Universidad> GetAllUniversidades();
        Universidad AddUniversidad(Universidad universidad);
        Universidad UpdateUniversidad(Universidad universidad);
        void DeleteUniversidad(int idUniversidad);
        Universidad GetUniversidad(int idUniversidad);
    }
}