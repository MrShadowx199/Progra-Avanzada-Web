using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Carrito
    {
        [Key]
        public int CarritoID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        [ForeignKey("Producto")]
        public int ProductoID { get; set; }

        [Required]
        public int Cantidad { get; set; }

        public DateTime FechaAgregado { get; set; } = DateTime.Now;

        public Usuario Usuario { get; set; }
        public Producto Producto { get; set; }
    }
}
