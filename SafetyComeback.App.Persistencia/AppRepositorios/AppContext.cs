using Microsoft.EntityFrameworkCore;
using SafetyComeback.App.Dominio;

namespace SafetyComeback.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Universidad> Universidades {get;set;}
        public DbSet<Salon> Salones {get;set;}
        public DbSet<Programa> Programas {get;set;}
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Directivo> Directivos {get;set;}
        public DbSet<Clase> Clases {get;set;}
        public DbSet<Dependencia> Dependencias {get;set;}
        public DbSet<Estudiante> Estudiantes {get;set;}
        public DbSet<Facultad> Facultades {get;set;}
        public DbSet<Profesor> Profesores {get;set;}
        public DbSet<Sede> Sedes {get;set;}
        public DbSet<ServicioGeneral> ServiciosGenerales {get;set;}
        public DbSet<Sintoma> Sintomas {get;set;}
        public DbSet<AforoClase> AforoClases {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDb; Initial Catalog=SafetyComebackData_V7");
            }
        }
    }
}