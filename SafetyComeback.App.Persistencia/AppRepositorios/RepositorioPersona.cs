using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona:IRepositorioPersona
    {
        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        Persona IRepositorioPersona.GetPersona(string identiPersona)
        {
            Persona personaencontrada = new Persona();
            if (!string.IsNullOrEmpty(identiPersona))
            {
                personaencontrada = _appContext.Personas.Where(p =>p.Identificacion==identiPersona).FirstOrDefault();
            }
            return personaencontrada;
        }
    }
}