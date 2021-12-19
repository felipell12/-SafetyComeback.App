using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Sintoma
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage="La fecha es obligatoria")]
        [Display(Name="Fecha de reporte")]
        public DateTime Fecha {get; set;}

        public int PersonaId {get; set;}

        [Required(ErrorMessage="El periodo de aislamiento es obligatorio")]
        [Display(Name="Periodo de asilamiento (valor entre 1 y 14 días)")]
        public int PeriodoAislamiento {get; set;}
        
        [Required(ErrorMessage="Los síntomas son obligatorios")]
        [StringLength(100, ErrorMessage="Los {0} deben tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Síntomas")]
        public string Sintomas { get; set;}

        public virtual Persona Persona {get; set;}
    }
}