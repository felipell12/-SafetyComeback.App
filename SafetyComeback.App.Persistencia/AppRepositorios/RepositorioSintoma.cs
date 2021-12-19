using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioSintoma:IRepositorioSintoma
    {
        private readonly AppContext _appContext;

        public RepositorioSintoma(AppContext appContext)
        {
            _appContext = appContext;
        }

        Sintoma IRepositorioSintoma.AddSintoma(Sintoma sintoma)
        {
            var sintomaAdicionado = _appContext.Sintomas.Add(sintoma);
            _appContext.SaveChanges();
            return sintomaAdicionado.Entity;
        }

        void IRepositorioSintoma.DeleteSintoma(int idSintoma)
        {
            var sintomaEncontrado = _appContext.Sintomas.FirstOrDefault(p => p.Id == idSintoma);
            if (sintomaEncontrado == null)
                return;
            _appContext.Sintomas.Remove(sintomaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Sintoma> IRepositorioSintoma.GetAllSintomas(int idPersona)
        {
            return _appContext.Sintomas.Where(p => p.PersonaId == idPersona).OrderByDescending(p => p.Fecha);
        }

        Sintoma IRepositorioSintoma.GetSintoma(int idSintoma)
        {
            return _appContext.Sintomas.FirstOrDefault(p => p.Id == idSintoma);
        }

        Sintoma IRepositorioSintoma.UpdateSintoma(Sintoma sintoma)
        {
            var sintomaEncontrado = _appContext.Sintomas.FirstOrDefault(p => p.Id == sintoma.Id);
            if (sintomaEncontrado != null)
            {
                sintomaEncontrado.Fecha = sintoma.Fecha;
                sintomaEncontrado.PeriodoAislamiento = sintoma.PeriodoAislamiento;
                sintomaEncontrado.Sintomas= sintoma.Sintomas;
                sintomaEncontrado.PersonaId = sintoma.PersonaId;
                _appContext.SaveChanges();
            }
            return sintomaEncontrado;
        }
    }
}