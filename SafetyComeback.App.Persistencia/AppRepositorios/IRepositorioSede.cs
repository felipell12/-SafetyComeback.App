using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Sede
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes();
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);
    }
}