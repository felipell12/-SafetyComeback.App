using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SafetyComeback.App.Dominio
{
    public class Clase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El programa o carrera de la clase es obligatoria")]
        [Display(Name="Programa/Carrera")]
        public int ProgramaId {get; set;}
        
        [Required(ErrorMessage="El salón de la clase es obligatorio")]
        [Display(Name="Salón")]
        public int SalonId {get; set;}

        [Required(ErrorMessage="La fecha es obligatoria")]
        [Display(Name="Fecha de la Clase")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set;}
        
        [Required(ErrorMessage="La hora es obligatoria")]
        [DataType(DataType.Time)]
        [Display(Name="Hora de la Clase")]
        public DateTime Hora {get; set;}
        
        [Required(ErrorMessage="La duración es obligatoria")]
        [Range(1, 90)]
        [Display(Name="Duración de la Clase (Minutos)")]
        public int Duracion {get; set;}

        public Programa Programa {get; set;}
        public Salon Salon {get;set;}
        public ICollection<AforoClase> AforoClases {get; set;}

    }
}