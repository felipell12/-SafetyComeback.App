using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Facultad
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioFacultad:IRepositorioFacultad
    {
        private readonly AppContext _appContext;

        public RepositorioFacultad(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Facultad IRepositorioFacultad.AddFacultad(Facultad facultad)
        {
            var facultadAdicionada= _appContext.Facultades.Add(facultad);
            _appContext.SaveChanges();
            return facultadAdicionada.Entity;
        }

        void IRepositorioFacultad.DeleteFacultad(int idFacultad)
        {
            var facultadEncontrada= _appContext.Facultades.FirstOrDefault(p =>p.Id==idFacultad);
            if(facultadEncontrada==null)
                return;
            _appContext.Facultades.Remove(facultadEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Facultad> IRepositorioFacultad.GetAllFacultades()
        {
            return _appContext.Facultades;
        }

        Facultad IRepositorioFacultad.GetFacultad(int idFacultad)
        {
            var facultadEncontrada= _appContext.Facultades
                                .Include(p =>p.Programas)
                                .FirstOrDefault(p =>p.Id==idFacultad);
            return facultadEncontrada;
        }

        Facultad IRepositorioFacultad.UpdateFacultad(Facultad facultad)
        {
            var facultadEncontrada= _appContext.Facultades.FirstOrDefault(p =>p.Id==facultad.Id);
            if ( facultadEncontrada!=null )
            {
                facultadEncontrada.Nombre=facultad.Nombre;
                _appContext.SaveChanges();
            }
            return facultadEncontrada;
        }

    }
}