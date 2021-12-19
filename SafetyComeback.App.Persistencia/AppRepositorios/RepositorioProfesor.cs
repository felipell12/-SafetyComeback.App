using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioProfesor:IRepositorioProfesor
    {
        private readonly AppContext _appContext;

        public RepositorioProfesor(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Profesor IRepositorioProfesor.AddProfesor(Profesor profesor)
        {
            var profesorAdicionado= _appContext.Profesores.Add(profesor);
            _appContext.SaveChanges();
            return profesorAdicionado.Entity;
        }

        void IRepositorioProfesor.DeleteProfesor(int idProfesor)
        {
            var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p =>p.Id==idProfesor);
            if(profesorEncontrado==null)
                return;
            _appContext.Profesores.Remove(profesorEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesores()
        {
            return _appContext.Profesores.Include(p =>p.Facultad);
        }

        Profesor IRepositorioProfesor.GetProfesor(int idProfesor)
        {
            return _appContext.Profesores.FirstOrDefault(p => p.Id==idProfesor);
        }

        Profesor IRepositorioProfesor.UpdateProfesor(Profesor profesor)
        {
            var profesorEncontrado= _appContext.Profesores.FirstOrDefault(p => p.Id==profesor.Id);
            if ( profesorEncontrado!=null )
            {
                profesorEncontrado.Nombres=profesor.Nombres;
                profesorEncontrado.Apellidos=profesor.Apellidos;
                profesorEncontrado.Identificacion=profesor.Identificacion;
                profesorEncontrado.Edad=profesor.Edad;
                profesorEncontrado.Estado_COVID=profesor.Estado_COVID;
                profesorEncontrado.FacultadId=profesor.FacultadId;
                profesorEncontrado.Materia=profesor.Materia;
                _appContext.SaveChanges();
            }
            return profesorEncontrado;
        }

        IEnumerable<Profesor> IRepositorioProfesor.GetAllProfesoresSearch(string filtro=null)
        {
            IEnumerable<Profesor> personas;
            //_appContext.Profesores.Include(p =>p.Facultad);
                if(!string.IsNullOrEmpty(filtro))
                {
                    personas=_appContext.Profesores.Where(p =>p.Nombres.Contains(filtro) || p.Apellidos.Contains(filtro) || p.Identificacion.Contains(filtro)).Include(p =>p.Facultad);
                }
                else
                {
                    personas = _appContext.Profesores.Include(p =>p.Facultad);
                }
            return personas;
        }
    }
}