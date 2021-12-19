using System.Collections.Generic;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSintoma
    {
        IEnumerable<Sintoma> GetAllSintomas(int idPersona);
        Sintoma AddSintoma(Sintoma sintoma);
        Sintoma UpdateSintoma(Sintoma sintoma);
        void DeleteSintoma(int idSintoma);
        Sintoma GetSintoma(int idSintoma);
    }
}