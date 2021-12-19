using System.Collections.Generic;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSalon
    {
        IEnumerable<Salon> GetAllSalones();
        Salon AddSalon(Salon salon);
        Salon UpdateSalon(Salon salon);
        void DeleteSalon(int idSalon);
        Salon GetSalon(int idsalon);

    }
}