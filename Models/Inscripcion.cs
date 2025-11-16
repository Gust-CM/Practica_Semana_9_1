using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTalleres.Models
{
    public class Inscripcion
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Debe tener mínimo 2 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Debe tener mínimo 2 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d{8,}$", ErrorMessage = "Debe tener mínimo 8 dígitos")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un taller")]
        public string Taller { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un nivel de experiencia")]
        public string NivelExperiencia { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una fecha")]
        [DataType(DataType.Date)]
        public DateTime FechaTaller { get; set; }

        [Required(ErrorMessage = "Debe aceptar los términos")]
        public bool AceptaTerminos { get; set; }
    }
}