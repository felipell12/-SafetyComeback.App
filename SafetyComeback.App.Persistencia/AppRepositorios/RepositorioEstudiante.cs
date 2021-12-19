using System.Collections.Generic;
//using System.Web.WebPages.Html;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Estudiante
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioEstudiante:IRepositorioEstudiante
    {
        private readonly AppContext _appContext;

        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado= _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;
        }

        void IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(p =>p.Id==idEstudiante);
            if(estudianteEncontrado==null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes.Include(p =>p.Programa);
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            return _appContext.Estudiantes.FirstOrDefault(p =>p.Id==idEstudiante);
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(p =>p.Id==estudiante.Id);
            if ( estudianteEncontrado!=null )
            {
                estudianteEncontrado.Nombres=estudiante.Nombres;
                estudianteEncontrado.Apellidos=estudiante.Apellidos;
                estudianteEncontrado.Identificacion=estudiante.Identificacion;
                estudianteEncontrado.Edad=estudiante.Edad;
                estudianteEncontrado.Estado_COVID=estudiante.Estado_COVID;
                estudianteEncontrado.ProgramaId=estudiante.ProgramaId;
                estudianteEncontrado.Semestre=estudiante.Semestre;
                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantesSearch(string filtro=null)
        {
            IEnumerable<Estudiante> personas;
           // _appContext.Estudiantes.Include(p =>p.Programa);
                if(!string.IsNullOrEmpty(filtro))
                {
                    personas=_appContext.Estudiantes.Where(p =>p.Nombres.Contains(filtro) || p.Apellidos.Contains(filtro) || p.Identificacion.Contains(filtro)).Include(p =>p.Programa);
                }
                else
                {
                    personas = _appContext.Estudiantes.Include(p =>p.Programa);
                }
            return personas;
        }

    }
}