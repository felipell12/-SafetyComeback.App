using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class AforoClase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="La clase es obligatoria")]
        [Display(Name="Clase")]
        public int ClaseId {get; set;}

        [Required(ErrorMessage="La persona es obligatoria")]
        [Display(Name="Estudiante/Directivo/Profesor")]
        public int PersonaId {get; set;}

        public virtual Clase Clase {get;set;}
        public virtual Persona Persona {get;set;}

    }
}