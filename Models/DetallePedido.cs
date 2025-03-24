using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class DetallePedido
    {
        [Key]
        public int DetallePedidoID { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoID { get; set; }

        [ForeignKey("Producto")]
        public int ProductoID { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
    }
}
