using System.Collections.Generic;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAforoClase
    {
        IEnumerable<AforoClase> GetAllAforoClase(int idClase);
        AforoClase AddAforoClase(AforoClase aforoClase);
        AforoClase UpdateAforoClase(AforoClase aforoClase);
        void DeleteAforoClase(int idAforoClase);
        AforoClase GetAforoClase(int idAforoClase);
        Persona GetPersona(int personaId);
        Clase GetClase(int claseId);
    }
}