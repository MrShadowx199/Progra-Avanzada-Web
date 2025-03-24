using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Rol
    {
       [Key]
        public int RolID { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreRol { get; set; }
    }
}
