using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Clase
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioClase:IRepositorioClase
    {
        private readonly AppContext _appContext;

        public RepositorioClase(AppContext appContext)
        {
            _appContext = appContext;
        }

        Clase IRepositorioClase.AddClase(Clase clase)
        {
            var claseAdicionada = _appContext.Clases.Add(clase);
            _appContext.SaveChanges();
            return claseAdicionada.Entity;
        }

        void IRepositorioClase.DeleteClase(int idClase)
        {
            var claseEncontrada = _appContext.Clases.FirstOrDefault(p => p.Id == idClase);
            if (claseEncontrada == null)
                return;
            _appContext.Clases.Remove(claseEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Clase> IRepositorioClase.GetAllClases()
        {
            return _appContext.Clases.Include(p =>p.Programa).Include(p =>p.Salon);
        }

        Clase IRepositorioClase.GetClase(int idClase)
        {
            return _appContext.Clases.FirstOrDefault(p => p.Id == idClase);
        }

        Clase IRepositorioClase.UpdateClase(Clase clase)
        {
            var claseEncontrada = _appContext.Clases.FirstOrDefault(p => p.Id == clase.Id);
            if (claseEncontrada != null)
            {
                claseEncontrada.ProgramaId= clase.ProgramaId;
                claseEncontrada.SalonId=clase.SalonId;
                claseEncontrada.Fecha= clase.Fecha;
                claseEncontrada.Hora= clase.Hora;
                claseEncontrada.Duracion = clase.Duracion;
                _appContext.SaveChanges();
            }
            return claseEncontrada;
        }
    }
}