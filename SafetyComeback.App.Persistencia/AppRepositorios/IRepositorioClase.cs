using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Clase
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioClase
    {
        IEnumerable<Clase> GetAllClases();
        Clase AddClase(Clase clase);
        Clase UpdateClase(Clase clase);
        void DeleteClase(int idClase);
        Clase GetClase(int idClase);

    }
}