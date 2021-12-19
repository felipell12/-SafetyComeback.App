using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Sede
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioSede:IRepositorioSede
    {
        private readonly AppContext _appContext;

        public RepositorioSede(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Sede IRepositorioSede.AddSede(Sede sede)
        {
            var sedeAdicionada= _appContext.Sedes.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionada.Entity;
        }

        void IRepositorioSede.DeleteSede(int idSede)
        {
            var sedeEncontrada= _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);
            if(sedeEncontrada==null)
                return;
            _appContext.Sedes.Remove(sedeEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Sede> IRepositorioSede.GetAllSedes()
        {
            return _appContext.Sedes;
        }

        Sede IRepositorioSede.GetSede(int idSede)
        {
            return _appContext.Sedes.Include(p =>p.Salones)
                                .FirstOrDefault(p =>p.Id==idSede);
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            var sedeEncontrada= _appContext.Sedes.FirstOrDefault(p =>p.Id==sede.Id);
            if ( sedeEncontrada!=null )
            {
                sedeEncontrada.Nombre=sede.Nombre;
                _appContext.SaveChanges();
            }
            return sedeEncontrada;
        }

    }
}