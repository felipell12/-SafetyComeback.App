using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public class RepositorioSalon : IRepositorioSalon
    {
        private readonly AppContext _appContext;

        public RepositorioSalon(AppContext appContext)
        {
            _appContext = appContext;
        }

        Salon IRepositorioSalon.AddSalon(Salon salon)
        {
            var salonAdicionado = _appContext.Salones.Add(salon);
            _appContext.SaveChanges();
            return salonAdicionado.Entity;
        }

        void IRepositorioSalon.DeleteSalon(int idSalon)
        {
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.Id == idSalon);
            if (salonEncontrado == null)
                return;
            _appContext.Salones.Remove(salonEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Salon> IRepositorioSalon.GetAllSalones()
        {
            return _appContext.Salones.Include(p =>p.Sede);
        }

        Salon IRepositorioSalon.GetSalon(int idSalon)
        {
            return _appContext.Salones.Include(p =>p.Clases)
                                .FirstOrDefault(p => p.Id == idSalon);
        }

        Salon IRepositorioSalon.UpdateSalon(Salon salon)
        {
            var salonEncontrado = _appContext.Salones.FirstOrDefault(p => p.Id == salon.Id);
            if (salonEncontrado != null)
            {
                salonEncontrado.Numero = salon.Numero;
                salonEncontrado.Aforo = salon.Aforo;
                _appContext.SaveChanges();
            }
            return salonEncontrado;
        }
    }
}
