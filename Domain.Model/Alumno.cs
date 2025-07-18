﻿namespace Domain.Model
{
    public class Alumno
    {
        public static readonly List<Alumno> Lista = new();

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
        public string Direccion { get; set; }

        public Alumno(string nombre, string apellido, int legajo, string direccion)
        {
            Id = ObtenerProximoId();
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;
            Direccion = direccion;
        }

        public static int ObtenerProximoId() {
            return Lista.Count == 0 ? 1 : Lista.Max(a => a.Id) + 1;
        }
    }
}
