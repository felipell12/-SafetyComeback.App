using System;
using System.Collections.Generic;
using SafetyComeback.App.Dominio;
using SafetyComeback.App.Persistencia;
using SafetyComeback.App.Persistencia.AppRepositorios;

namespace SafetyComeback.App.Consola
{
    class Program
    {
        //Declaración de atributos de interface
    /*    private static IRepositorioUniversidad _repoUniversidad = new RepositorioUniversidad(new Persistencia.AppContext());
        private static IRepositorioFacultad _repoFacultad = new RepositorioFacultad(new Persistencia.AppContext());
        private static IRepositorioPrograma _repoPrograma = new RepositorioPrograma(new Persistencia.AppContext());
        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioClase _repoClase = new RepositorioClase(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - SafetyComeBack");
           // AddUniversidad();
           // AddFacultad();
           // AddPrograma();
            //AddSede();
          //  AddEstudiante();
          //  BuscarEstudiante(1);
           // BuscarUniversidad(1);
          //  BuscarFacultad(1);
          //  BuscarPrograma(1);
            //BuscarSede(1);
            //EliminarFacultad(4);
            //UpdateFacultad();
            //UpdateSede();
            //ListarFacultades();
            //ListarSedes();*/
        }
 
        //Uso funciones CRUD Universidad
        //Agregar Univerisidad
    /*    private static void AddUniversidad()
        {
            var universidad = new Universidad
            {
                Nombre="Universidad de Caldas"
            };
            _repoUniversidad.AddUniversidad(universidad);
        }

        //Buscar Univerisidad
        private static void BuscarUniversidad(int IdUniversidad)
        {
            var universidad=_repoUniversidad.GetUniversidad(IdUniversidad);
            Console.WriteLine(universidad.Nombre);
        }
       
        //Uso funciones CRUD Facultad
        //Agregar Facultad
        private static void AddFacultad()
        {
            var facultad = new Facultad
            {
                Nombre="Ingeniería"
            };
            _repoFacultad.AddFacultad(facultad);
        }

        //Buscar Facultad
        private static void BuscarFacultad(int IdFacultad)
        {
            var facultad=_repoFacultad.GetFacultad(IdFacultad);
            Console.WriteLine("Facultad: "+facultad.Nombre);
            Console.WriteLine("Lista de Programas");
            foreach(var prog in facultad.Programas) 
            {
               Console.WriteLine(prog.Nombre);
            }
        }

        //Eliminar Facultad
        private static void EliminarFacultad(int IdFacultad)
        {
            _repoFacultad.DeleteFacultad(IdFacultad);
            Console.WriteLine("Facultad eliminada con éxito");
        }

        //Modificar Facultad
        private static void UpdateFacultad()
        {
            var facultad = new Facultad
            {
                Id=2,
                Nombre="Ciencias Humanas"
            };
            var facultadModificada=_repoFacultad.UpdateFacultad(facultad);
            Console.WriteLine("Facultad "+facultadModificada.Nombre+"modificada con éxito ");
        }

        //Listar Facultades
        private static void ListarFacultades()
        {
            IEnumerable<Facultad> listaFacultades =_repoFacultad.GetAllFacultades();
            Console.WriteLine("Lista de Facultades");
            foreach(Facultad fac in listaFacultades) 
            {
               Console.WriteLine(fac.Nombre);
            }
        }

        //Uso funciones CRUD Programa
        //Agregar Programa
        private static void AddPrograma()
        {
            var programa = new Programa
            {
                Nombre="Ingeniería de Sistemas",
                FacultadId=1
            };
            _repoPrograma.AddPrograma(programa);
        }

        //Buscar Programa
        private static void BuscarPrograma(int IdPrograma)
        {
            var programa=_repoPrograma.GetPrograma(IdPrograma);
            Console.WriteLine("Programa: "+programa.Nombre);
        }

        //Uso funciones CRUD Sede
        //Agregar Sede
        private static void AddSede()
        {
            var sede = new Sede
            {
                Nombre="Sede Norte"
            };
            _repoSede.AddSede(sede);
        }

        //Buscar Sede
        private static void BuscarSede(int IdSede)
        {
            var sede=_repoSede.GetSede(IdSede);
            Console.WriteLine("Sede: "+sede.Nombre);
        }

        //Eliminar Sede
        private static void EliminarSede(int IdSede)
        {
            _repoSede.DeleteSede(IdSede);
            Console.WriteLine("Sede eliminada con éxito");
        }

        //Modificar Sede
        private static void UpdateSede()
        {
            var sede = new Sede
            {
                Id=1,
                Nombre="Sede Norte - FGRGR"
            };
            var sedeModificada=_repoSede.UpdateSede(sede);
            Console.WriteLine("Sede "+sedeModificada.Nombre+" modificada con éxito ");
        }

        //Listar Sedes
        private static void ListarSedes()
        {
            IEnumerable<Sede> listaSedes =_repoSede.GetAllSedes();
            Console.WriteLine("Lista de Sedes");
            foreach(Sede sede in listaSedes) 
            {
               Console.WriteLine(sede.Nombre);
            }
        }

        //Uso funciones CRUD Estudiante
        //Agregar Estudiante
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante
            {
                Nombres="Pepito",
                Apellidos="Pérez",
                Identificacion="99999999",
                Edad=23,
                Estado_COVID=EstadoCovid.Negativo,
                ProgramaId=1,
                Semestre=10
            };
            _repoEstudiante.AddEstudiante(estudiante);
        }

        //Buscar Estudiante
        private static void BuscarEstudiante(int IdEstudiante)
        {
            var estudiante=_repoEstudiante.GetEstudiante(IdEstudiante);
            Console.WriteLine("Nombre: "+estudiante.Id);
            var prog = estudiante.Programa;
            Console.WriteLine(prog.Nombre);
        }    

        //Uso funciones CRUD Clase
        //Agregar Clase
    private static void AddClase()
        {
            DateTime fechahora = new DateTime(2016, 6, 1, 6, 34, 53);
            var clase = new Clase
            {
               FechayHora = fechahora,
               Duracion= 30
            };
            _repoClase.AddClase(clase);
        }
        
        //Buscar Clase
        private static void BuscarClase(int IdClase)
        {
            var clase = _repoClase.GetClase(IdClase);
            Console.WriteLine(clase.FechayHora + " " + clase.Duracion);
        }

        //Modificar Clase      
        private static void UpdateClase()
        {
             DateTime fechahora = new DateTime(2021, 6, 2, 8, 00, 00);
            var clase = new Clase
            {
                Id=1,
                FechayHora = fechahora,
                Duracion= 10
            };
            var claseModificada = _repoClase.UpdateClase(clase);
            Console.WriteLine("clase fecha y hora " + claseModificada.FechayHora + " duracion "+ claseModificada.Duracion +" modificada con éxito ");
        }

        //Listar Clases    
        private static void ListarClases()
        {
            IEnumerable<Clase> listaClases = _repoClase.GetAllClases();
            Console.WriteLine("Lista de clases");
            foreach (Clase clase in listaClases)
            {
                Console.WriteLine("Id " + clase.Id + " fecha y hora " + clase.FechayHora + " duracion " + clase.Duracion);
            }
        }

        //Eliminar Clase
        private static void EliminarClase(int IdClase)
        {
            _repoClase.DeleteClase(IdClase);
            Console.WriteLine("clase eliminada con éxito");
        }
      
        //Uso funciones CRUD Salon
        //Agregar Salon
        private static void AddSalon()
        {
            var salon = new Salon
            {
                Numero = "708",
                Aforo = 30,
            };
            _repoSalon.AddSalon(salon);
        }

        //Buscar Salon
        private static void BuscarSalon(int IdSalon)
        {
            var salon = _repoSalon.GetSalon(IdSalon);
            Console.WriteLine(salon.Numero + " " + salon.Aforo);
        }

        //Modificar Salon
        private static void UpdateSalon()
        {
            var salon = new Salon
            {
                Id = 1,
                Numero = "598",
                Aforo = 10
            };
            var salonModificado = _repoSalon.UpdateSalon(salon);
            Console.WriteLine("salon numero " + salonModificado.Numero + " modificada con éxito ");
        }

        //Listar Salones
        private static void ListarSalones()
        {
            IEnumerable<Salon> listaSalones = _repoSalon.GetAllSalones();
            Console.WriteLine("Lista de Salones");
            foreach (Salon salon in listaSalones)
            {
                Console.WriteLine("Id " + salon.Id + " numero " + salon.Numero + " aforo " + salon.Aforo);
            }
        }

        //Eliminar Salon
        public static void EliminarSalon(int IdSalon)
        {
            _repoSalon.DeleteSalon(IdSalon);
            Console.WriteLine("Salon eliminado con éxito");
        }

        //Uso funciones CRUD Directivo
        //Agregar Directivo
        private static void AddDirectivo()
        {
            var directivo = new Directivo
            {
                Nombres="Andrés",
                Apellidos="Muñoz",
                Identificacion="4575689",
                Edad=36,
                Estado_COVID=EstadoCovid.Negativo,
                //Dependencia=BuscarDependencia(int IdDependencia).Id,
            
            };
            _repoDirectivo.AddDirectivo(directivo);
        }

        //Buscar Directivo
        private static void BuscarDirectivo(int IdDirectivo)
        {
            var directivo=_repoDirectivo.GetDirectivo(IdDirectivo);
            Console.WriteLine("Directivo: "+directivo.Nombres+" "+directivo.Apellidos+" "+directivo.Identificacion+" "+directivo.Dependencia);
        }

        //Eliminar Directivo
        private static void EliminarDirectivo(int IdDirectivo)
        {
            _repoDirectivo.DeleteDirectivo(IdDirectivo);
            Console.WriteLine("Directivo eliminado con éxito");
        }

        //Modificar Directivo
        private static void UpdateDirectivo()
        {
            var directivo = new Directivo
            {
                Id=1,
                Nombres="Oscar",
                Apellidos="Gutierrez"
            };
            var directivoModificado=_repoDirectivo.UpdateDirectivo(directivo);
            Console.WriteLine("Directivo "+directivoModificado.Nombres+" modificado con éxito ");
        }
        */
    
    } // fin clase
}
