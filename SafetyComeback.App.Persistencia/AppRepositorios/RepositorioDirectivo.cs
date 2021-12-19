using System.Collections.Generic;
using System.Linq;
using SafetyComeback.App.Dominio;

//Se implementa la interfaz del repositorio Directivo
//Se desarrollan los métodos en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioDirectivo:IRepositorioDirectivo
    {
        private readonly AppContext _appContext;

        public RepositorioDirectivo(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        Directivo IRepositorioDirectivo.AddDirectivo(Directivo directivo)
        {
            var directivoAdicionado= _appContext.Directivos.Add(directivo);
            _appContext.SaveChanges();
            return directivoAdicionado.Entity;
        }

        void IRepositorioDirectivo.DeleteDirectivo(int idDirectivo)
        {
            var directivoEncontrado= _appContext.Directivos.FirstOrDefault(p =>p.Id==idDirectivo);
            if(directivoEncontrado==null)
                return;
            _appContext.Directivos.Remove(directivoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivos()
        {
            return _appContext.Directivos;
        }

        Directivo IRepositorioDirectivo.GetDirectivo(int idDirectivo)
        {
            return _appContext.Directivos.FirstOrDefault(p =>p.Id==idDirectivo);
        }

        Directivo IRepositorioDirectivo.UpdateDirectivo(Directivo directivo)
        {
            var directivoEncontrado= _appContext.Directivos.FirstOrDefault(p =>p.Id==directivo.Id);
            if ( directivoEncontrado!=null )
            {
                directivoEncontrado.Nombres=directivo.Nombres;
                directivoEncontrado.Apellidos=directivo.Apellidos;
                directivoEncontrado.Identificacion=directivo.Identificacion;
                directivoEncontrado.Edad=directivo.Edad;
                directivoEncontrado.Estado_COVID=directivo.Estado_COVID;
                directivoEncontrado.Dependencia=directivo.Dependencia;
                _appContext.SaveChanges();
            }
            return directivoEncontrado;
        }

        IEnumerable<Directivo> IRepositorioDirectivo.GetAllDirectivosSearch(string filtro=null)
        {
            IEnumerable<Directivo> personas;
            //_appContext.Directivos;
                if(!string.IsNullOrEmpty(filtro))
                {
                    personas=_appContext.Directivos.Where(p =>p.Nombres.Contains(filtro) || p.Apellidos.Contains(filtro) || p.Identificacion.Contains(filtro));
                }
                else
                {
                    personas = _appContext.Directivos;
                }
            return personas;
        }

    }
}