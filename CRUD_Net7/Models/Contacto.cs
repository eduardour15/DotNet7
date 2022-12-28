using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Net7.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es bligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es bligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo Celular es bligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El campo Email es bligatorio")]
        public string Email { get; set; }
        public DateTime FechaDeCreacion { get; set; }
    }
}