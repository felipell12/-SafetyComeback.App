using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Directivo
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<Directivo> GetAllDirectivos();
        Directivo AddDirectivo(Directivo directivo);
        Directivo UpdateDirectivo(Directivo directivo);
        void DeleteDirectivo(int idDirectivo);
        Directivo GetDirectivo(int idDirectivo);
        IEnumerable<Directivo> GetAllDirectivosSearch(string filtro);
    }
}