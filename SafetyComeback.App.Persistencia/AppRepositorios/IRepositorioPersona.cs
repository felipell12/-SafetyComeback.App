using System.Collections.Generic;
using SafetyComeback.App.Dominio;

//Interfaz repositorio Persona
//Se firman los métodos a desarrollar en el Repositorio
namespace SafetyComeback.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
          Persona GetPersona(string identiPersona);
    }
}