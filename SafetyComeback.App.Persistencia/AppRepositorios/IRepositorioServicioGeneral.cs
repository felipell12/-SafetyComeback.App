using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio ServicioGeneral
//Se firman los métodos a desarrollar en el Repositorio

namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioServicioGeneral
    {
        IEnumerable<ServicioGeneral> GetAllServiciosGenerales();
        ServicioGeneral AddServicioGeneral(ServicioGeneral servicioGeneral);
        ServicioGeneral UpdateServicioGeneral(ServicioGeneral servicioGeneral);
        void DeleteServicioGeneral(int idServicioGeneral);
        ServicioGeneral GetServicioGeneral(int idServicioGeneral);
        IEnumerable<ServicioGeneral> GetAllServiciosGeneralesSearch(string filtro);
    }
}