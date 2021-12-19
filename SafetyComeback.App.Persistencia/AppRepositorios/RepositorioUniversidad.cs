using System.Collections.Generic;
using System.Linq;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Universidad
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioUniversidad:IRepositorioUniversidad
    {
        private readonly AppContext _appContext;

        public RepositorioUniversidad(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Universidad IRepositorioUniversidad.AddUniversidad(Universidad universidad)
        {
            var universidadAdicionada= _appContext.Universidades.Add(universidad);
            _appContext.SaveChanges();
            return universidadAdicionada.Entity;
        }

        void IRepositorioUniversidad.DeleteUniversidad(int idUniversidad)
        {
            var universidadEncontrada= _appContext.Universidades.FirstOrDefault(p =>p.Id==idUniversidad);
            if(universidadEncontrada==null)
                return;
            _appContext.Universidades.Remove(universidadEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Universidad> IRepositorioUniversidad.GetAllUniversidades()
        {
            return _appContext.Universidades;
        }

        Universidad IRepositorioUniversidad.GetUniversidad(int idUniversidad)
        {
            return _appContext.Universidades.FirstOrDefault(p =>p.Id==idUniversidad);
        }

        Universidad IRepositorioUniversidad.UpdateUniversidad(Universidad universidad)
        {
            var universidadEncontrada= _appContext.Universidades.FirstOrDefault(p =>p.Id==universidad.Id);
            if ( universidadEncontrada!=null )
            {
                universidadEncontrada.Nombre=universidad.Nombre;
                _appContext.SaveChanges();
            }
            return universidadEncontrada;
        }

    }
}