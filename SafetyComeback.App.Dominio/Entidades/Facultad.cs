using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{ 
    public class Facultad
    {
        [Key]
        public int Id {get;set;}
        
        [Required(ErrorMessage="El nombre de la facultad es obligatorio")]
        [StringLength(50, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Facultad")]
        public string Nombre {get; set;}

        public virtual ICollection<Programa> Programas { get; set; }
    }
}