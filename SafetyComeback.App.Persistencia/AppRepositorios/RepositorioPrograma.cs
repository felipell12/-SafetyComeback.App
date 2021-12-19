using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Programa
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioPrograma:IRepositorioPrograma
    {
        private readonly AppContext _appContext;

        public RepositorioPrograma(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Programa IRepositorioPrograma.AddPrograma(Programa programa)
        {
            var programaAdicionado= _appContext.Programas.Add(programa);
            _appContext.SaveChanges();
            return programaAdicionado.Entity;
        }

        void IRepositorioPrograma.DeletePrograma(int idPrograma)
        {
            var programaEncontrado= _appContext.Programas.FirstOrDefault(p =>p.Id==idPrograma);
            if(programaEncontrado==null)
                return;
            _appContext.Programas.Remove(programaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Programa> IRepositorioPrograma.GetAllProgramas()
        {
            return _appContext.Programas.Include(p =>p.Facultad);
        }

        Programa IRepositorioPrograma.GetPrograma(int idPrograma)
        {
            return _appContext.Programas.FirstOrDefault(p =>p.Id==idPrograma);
        }

        Programa IRepositorioPrograma.UpdatePrograma(Programa programa)
        {
            var programaEncontrado= _appContext.Programas.FirstOrDefault(p =>p.Id==programa.Id);
            if ( programaEncontrado!=null )
            {
                programaEncontrado.Nombre=programa.Nombre;
                programaEncontrado.FacultadId=programa.FacultadId;
                _appContext.SaveChanges();
            }
            return programaEncontrado;
        }

    }
}