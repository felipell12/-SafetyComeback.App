using System;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Estudiante:Persona
    {
        //public int Id {get;set;}
        [Required(ErrorMessage="La carrera es obligatoria")]
        [Display(Name="Carrera")]
        public int ProgramaId {get; set;}

        [Range(1, 10)]
        [Display(Name="Semestre cursado")]
        public int Semestre {get; set;}

        public virtual Programa Programa {get; set;}
    }
}