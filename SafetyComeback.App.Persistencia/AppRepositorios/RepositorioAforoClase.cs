using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioAforoClase:IRepositorioAforoClase
    {
        private readonly AppContext _appContext;

        public RepositorioAforoClase(AppContext appContext)
        {
            _appContext = appContext;
        }

        AforoClase IRepositorioAforoClase.AddAforoClase(AforoClase aforoClase)
        {
            var aforoClaseAdicionado = _appContext.AforoClases.Add(aforoClase);
            _appContext.SaveChanges();
            return aforoClaseAdicionado.Entity;
        }

        void IRepositorioAforoClase.DeleteAforoClase(int idAforoClase)
        {
            var aforoClaseEncontrado = _appContext.AforoClases.FirstOrDefault(p => p.Id == idAforoClase);
            if (aforoClaseEncontrado == null)
                return;
            _appContext.AforoClases.Remove(aforoClaseEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<AforoClase> IRepositorioAforoClase.GetAllAforoClase(int idClase)
        {
            return _appContext.AforoClases.Where(p => p.ClaseId == idClase)
                                    .Include(p =>p.Clase)
                                        .ThenInclude(clase => clase.Salon)
                                    .Include(p =>p.Persona);
        }

        AforoClase IRepositorioAforoClase.GetAforoClase(int idAforoClase)
        {
            return _appContext.AforoClases.FirstOrDefault(p => p.Id == idAforoClase);
        }

        AforoClase IRepositorioAforoClase.UpdateAforoClase(AforoClase aforoClase)
        {
            var aforoClaseEncontrado = _appContext.AforoClases.FirstOrDefault(p => p.Id == aforoClase.Id);
            if (aforoClaseEncontrado != null)
            {
                aforoClaseEncontrado.ClaseId = aforoClase.ClaseId;
                aforoClaseEncontrado.PersonaId = aforoClase.PersonaId;
                _appContext.SaveChanges();
            }
            return aforoClaseEncontrado;
        }

        Persona IRepositorioAforoClase.GetPersona(int personaId)
        {
            Persona personaencontrada = new Persona();
           // if (!string.IsNullOrEmpty(identiPersona))
           // {
                personaencontrada = _appContext.Personas.Where(p =>p.Id==personaId).FirstOrDefault();
            //}
            return personaencontrada;
        }

        Clase IRepositorioAforoClase.GetClase(int claseId)
        {
            Clase act_clase = new Clase();
            act_clase = _appContext.Clases
                            .Where(p =>p.Id==claseId)
                            .Include(p =>p.Salon)
                            .Include(p =>p.Programa)
                            .FirstOrDefault();
            return act_clase;
        }


        
    }
}