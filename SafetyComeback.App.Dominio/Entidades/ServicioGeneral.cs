using System;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class ServicioGeneral : Persona
    {
        [Required(ErrorMessage="El turno es obligatorio")]
        [Display(Name="Turno")]
        public string turno { get; set; }
    }
}