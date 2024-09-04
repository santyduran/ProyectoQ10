using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
/*
         * 
         * 1. guardar en una lista tareas - OK
         * 2. ver la lista de tareas - ok
         * 3. marcar las tareas completadas  string, estado  
         *  Tarea- ok
         *      Descripcion string
         *      Fecha DateTime
         *      Estado EstadoEnum
         * 
         4. clear una clase TODO- ok
         *  1. lista , ejemplo hotel y listado de habitaciones
         *  2. metodo para crear los elementos en la lista
         *      descripcion
         *      fecha
         *      estado sin completar
         *  2. metodo para eliminar tarea
         *      buscar y elimianr de la lista
         *      //listademo.Add(new Demo("PEPPITO PERES"));
         *  3. metodo para listar
         *      recorerr la lista con un foreach e imprimi en pantalla la informacion
         *          foreach
         *              Console.writeline
         *  4.
         */
namespace ProyectoQ10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var todo = new ToDo();

         
            var sw = false;
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Agregar tareas");
                Console.WriteLine("2. Listar tareas registradas");
                Console.WriteLine("3. Marcar tareas como completadas");
                Console.WriteLine("4. Eliminar tareas");
                Console.WriteLine("5. Salir");

                string comando = Console.ReadLine();

                switch (comando)
                {
                    case "1": {
                            Console.WriteLine("== Agregar tareas ==");
                            Console.WriteLine("Describa la tarea");
                            string descripcion = Console.ReadLine();
                            Console.WriteLine("fecha limite de la tarea");
                            string fecha = Console.ReadLine();
                          
                            //dtring fecha 
                            DateTime fechaIngresada = DateTime.Parse(fecha);
                            todo.RegistrarTarea(descripcion, fechaIngresada);
                        } break;
                    case "2": {

                            todo.ListarTareas();


                        } break;
                    case "3": {
                            Console.WriteLine("Ingrese descripcion de la tarea");
                            string descripcion = Console.ReadLine();
                            todo.MarcarTareaComoCompletada(descripcion);

                        } break;

                    case "4": {
                            Console.WriteLine("Ingrese descripcion de la tarea que desea eliminar");
                            string descripcion = Console.ReadLine();
                            todo.EliminarTareas(descripcion);

                        } break;
                    case "5": {
                            sw = true;
                            Console.WriteLine("salir");
                        } break;

                }
            }
            while (!sw);


            Console.Read();

        }
    }
    


    public enum EstadoEnum
    {
        SinCompletar,
        Completadas
    }
}
