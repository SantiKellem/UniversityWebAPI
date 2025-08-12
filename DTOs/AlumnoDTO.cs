using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class AlumnoDTO
    {
        public int Id { get; set; }
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
