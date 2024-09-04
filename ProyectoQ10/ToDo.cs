using System;
using System.Collections.Generic;
using System.Threading;

namespace ProyectoQ10
{
    public class ToDo {
        List<Tarea> listaTarea = new List<Tarea>();

        public void RegistrarTarea(string descripcion, DateTime fecha)
        {
            listaTarea.Add(new Tarea(descripcion, fecha, EstadoEnum.SinCompletar));
        }

        public void ListarTareas()
        {
            for (int i = 0; i < listaTarea.Count; i++)
            {
                var tarea = listaTarea[i]; 
                Console.WriteLine($"Descripción: {tarea.Descripcion}");
                Console.WriteLine($"Fecha: {tarea.Fecha}");
                Console.WriteLine($"Estado: {tarea.Estado}");
                Console.WriteLine("-------------------------");
            }
            //foreach(var tarea in listaTarea)
            //{
            //    Console.WriteLine($"Descripción: {tarea.Descripcion}");
            //    Console.WriteLine($"Fecha: {tarea.Fecha}");
            //    Console.WriteLine($"Estado: {tarea.Estado}");
            //    Console.WriteLine("-------------------------");
            //}
        }
        public void MarcarTareaComoCompletada(string descripcion)
        {
            for (int i = 0; i < listaTarea.Count; i++)
            {
                var tarea = listaTarea[i];
                if (tarea.Descripcion == descripcion)
                {
                    tarea.Estado = EstadoEnum.Completadas;
                }
            }

        }

        internal void EliminarTareas(string descripcion)
        {
            for(int i = 0; i < listaTarea.Count; i++)
            {
                var tarea = listaTarea[i];
                if (tarea.Descripcion == descripcion)
                {
                    listaTarea.Remove(tarea);
                }
            }
        }
    }
}
