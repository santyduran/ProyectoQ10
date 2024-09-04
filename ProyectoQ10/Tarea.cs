using System;

namespace ProyectoQ10
{
    public class Tarea
    {
        public Tarea(string descripcion, DateTime fecha, EstadoEnum estado)
        {
            Descripcion = descripcion;
            Estado = estado;
            Fecha = fecha;
        }



        public string Descripcion { get; }
        public EstadoEnum Estado { get;set; }
        public DateTime Fecha { get; }
        
    }
}
