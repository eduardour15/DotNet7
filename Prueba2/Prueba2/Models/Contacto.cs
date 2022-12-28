using System.ComponentModel.DataAnnotations;

namespace Prueba2.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Celular es obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo Email es obligatorio")]
        public string Email { get; set; }
        public DateTime FechaDeCreacion { get; set; }
    }
}
