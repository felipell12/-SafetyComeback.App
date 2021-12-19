using System;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
public class Directivo:Persona
    {
        //public int Id { get; set; }
        
        [Required(ErrorMessage="La dependencia es obligatoria")]
        [StringLength(20, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=3)]
        [Display(Name="Dependencia")]
        public string Dependencia {get; set;}

    }
}