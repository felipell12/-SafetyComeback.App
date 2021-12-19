using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Facultad
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioFacultad
    {
        IEnumerable<Facultad> GetAllFacultades();
        Facultad AddFacultad(Facultad facultad);
        Facultad UpdateFacultad(Facultad facultad);
        void DeleteFacultad(int idFacultad);
        Facultad GetFacultad(int idFacultad);
    }
}