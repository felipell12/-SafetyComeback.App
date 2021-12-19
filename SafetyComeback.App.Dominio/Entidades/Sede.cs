using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Sede
    {
        public int Id {get; set;}
        public string Nombre { get; set; }

        public virtual ICollection<Dependencia> Dependencias { get; set; }
        public virtual ICollection<Salon> Salones { get; set; }
    }
}