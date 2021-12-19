using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Salon
    {
        public int Id {get;set;}

        [Required(ErrorMessage="El número de salón es obligatorio")]
        [StringLength(7, ErrorMessage="El {0} debe tener mínimo {2} y máximo {1} caracteres", MinimumLength=1)]
        [Display(Name="Número del salón")]
        public string Numero {get; set;}

        [Required(ErrorMessage="El aforo máximo permitido es obligatorio")]
        [Display(Name="Aforo máximo (valor entre 1 y 25 personas)")]
        public int Aforo {get; set;}

        public int SedeId {get; set;}

        public virtual Sede Sede {get; set;}
        public virtual ICollection<Clase> Clases { get; set; }
    }
}