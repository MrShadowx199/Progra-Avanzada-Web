using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int CantidadStock { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string Estado { get; set; } = "Activo";

        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }

        public Categoria Categoria { get; set; }
    }
}
