using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string CorreoElectronico { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        public string Contraseña { get; set; }

        [StringLength(20)]
        public string Estado { get; set; } = "Activo";

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        [ForeignKey("Rol")]
        public int RolID { get; set; }

        public Rol Rol { get; set; }


    }
}
