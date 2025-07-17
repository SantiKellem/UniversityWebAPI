using Domain.Model;
using DTOs;

namespace Domain.Services
{
    public class AlumnoService
    {
        public IEnumerable<Alumno> getAll()
        {
            return Alumno.Lista;
        }

        public Alumno? getById(int id)
        {
            return Alumno.Lista.FirstOrDefault(a => a.Id == id);
        }

        public Alumno createAlumno(AlumnoDTO alumno)
        {
            var newAlumno = new Alumno(
                alumno.Nombre, 
                alumno.Apellido, 
                alumno.Legajo, 
                alumno.Direccion
            );

            Alumno.Lista.Add(newAlumno);
            return newAlumno;
        }

        public Alumno? updateAlumno(int id, AlumnoDTO alumno)
        {
            var existingAlumno = getById(id);
            if (existingAlumno is null) return null;
           
            existingAlumno.Nombre = alumno.Nombre;
            existingAlumno.Apellido = alumno.Apellido;
            existingAlumno.Legajo = alumno.Legajo;
            existingAlumno.Direccion = alumno.Direccion;

            return existingAlumno;
        }

        public bool deleteAlumno(int id)
        {
            var existingAlumno = getById(id);
            if (existingAlumno is null) return false;

            Alumno.Lista.Remove(existingAlumno);
            return true;
        }
    }
}
