using System;
using System.ComponentModel.DataAnnotations;

namespace SafetyComeback.App.Dominio
{
    public class Dependencia
    {
        public int Id {get;set;}
        public string Numero {get; set;}
        public int Aforo {get; set;}
        public int SedeId {get; set;}
        
        public Sede Sede {get; set;}
    }
}