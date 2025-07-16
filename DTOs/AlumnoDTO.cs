using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class AlumnoDTO
    {
        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Legajo { get; set; }

        [Required]
        public string Direccion { get; set; }

    }
}
