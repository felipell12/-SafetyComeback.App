using System.Collections.Generic;
using System.Linq;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioServicioGeneral: IRepositorioServicioGeneral
    {
        private readonly AppContext _appContext;

        public RepositorioServicioGeneral(AppContext appContext)
        {
            _appContext=appContext;
        }
        
        ServicioGeneral IRepositorioServicioGeneral.AddServicioGeneral(ServicioGeneral servicioGeneral)
        {
            var servicioGeneralAdicionado= _appContext.ServiciosGenerales.Add(servicioGeneral);
            _appContext.SaveChanges();
            return servicioGeneralAdicionado.Entity;
        }

        void IRepositorioServicioGeneral.DeleteServicioGeneral(int idServicioGeneral)
        {
            var servicioGeneralEncontrado= _appContext.ServiciosGenerales.FirstOrDefault(p =>p.Id==idServicioGeneral);
            if(servicioGeneralEncontrado==null)
                return;
            _appContext.ServiciosGenerales.Remove(servicioGeneralEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<ServicioGeneral> IRepositorioServicioGeneral.GetAllServiciosGenerales()
        {
            return _appContext.ServiciosGenerales;
        }

        ServicioGeneral IRepositorioServicioGeneral.GetServicioGeneral(int idServicioGeneral)
        {
            return _appContext.ServiciosGenerales.FirstOrDefault(p => p.Id==idServicioGeneral);
        }

        ServicioGeneral IRepositorioServicioGeneral.UpdateServicioGeneral(ServicioGeneral servicioGeneral)
        {
            var servicioGeneralEncontrado= _appContext.ServiciosGenerales.FirstOrDefault(p => p.Id==servicioGeneral.Id);
            if ( servicioGeneralEncontrado!=null )
            {
                servicioGeneralEncontrado.Nombres=servicioGeneral.Nombres;
                servicioGeneralEncontrado.Apellidos=servicioGeneral.Apellidos;
                servicioGeneralEncontrado.Identificacion=servicioGeneral.Identificacion;
                servicioGeneralEncontrado.Edad=servicioGeneral.Edad;
                servicioGeneralEncontrado.Estado_COVID=servicioGeneral.Estado_COVID;
                //servicioGeneralEncontrado.Facultad=servicioGeneral.Facultad;
                servicioGeneralEncontrado.turno=servicioGeneral.turno;
                _appContext.SaveChanges();
            }
            return servicioGeneralEncontrado;
        }

        IEnumerable<ServicioGeneral> IRepositorioServicioGeneral.GetAllServiciosGeneralesSearch(string filtro=null)
        {
            IEnumerable<ServicioGeneral> personas;
                if(!string.IsNullOrEmpty(filtro))
                {
                    personas=_appContext.ServiciosGenerales.Where(p =>p.Nombres.Contains(filtro) || p.Apellidos.Contains(filtro) || p.Identificacion.Contains(filtro));
                }
                else
                {
                    personas = _appContext.ServiciosGenerales;
                }
            return personas;
        }
    }
}