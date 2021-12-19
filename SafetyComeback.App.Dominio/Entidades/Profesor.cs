using System;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Profesor:Persona
    {
        //public int Id {get;set;}
        [Required(ErrorMessage="La facultad es obligatoria")]
        [Display(Name="Facultad")]
        public int FacultadId {get; set;}
        
        [Required(ErrorMessage="La materia es obligatoria")]
        [Display(Name="Materia")]
        public string Materia {get; set;}

        public virtual Facultad Facultad {get; set;}
    }
}