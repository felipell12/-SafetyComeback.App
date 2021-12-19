using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
public class Programa
    {
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre del programa es obligatorio")]
        [StringLength(50, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Programa/Carrera")]
        public string Nombre { get; set;}
        
        [Required(ErrorMessage="La facultad a la que pertenece el programa es obligatorio")]
        [Display(Name="Facultad")]
        public int FacultadId {get; set;}

        public Facultad Facultad {get;set;}
  //      public virtual ICollection<Persona> Personas { get; set; }
    }
}