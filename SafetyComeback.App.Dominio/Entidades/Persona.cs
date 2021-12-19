using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre de la persona es obligatorio")]
        [StringLength(20, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Nombres")]
        public string Nombres { get; set;}

        [Required(ErrorMessage="El apellido de la persona es obligatorio")]
        [StringLength(20, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Apellidos")]
        public string Apellidos { get;set;}

        [Required(ErrorMessage="La identificación de la persona es obligatoria")]
        [StringLength(12, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Documento de identificación")]
        public string Identificacion { get;set;}

        [Required(ErrorMessage="La edad de la persona es obligatoria")]
        [Range(12, 90)]
        [Display(Name="Edad (años cumplidos)")]
        public int Edad {get;set;}
        
        [Required(ErrorMessage="El estado de COVID es obligatorio")]
        [Display(Name="Estado COVID (Negativo, Positivo Sin_prueba)")]
        public EstadoCovid Estado_COVID { get; set;}

        public virtual ICollection<Sintoma> Sintomas { get; set; }
    }
}