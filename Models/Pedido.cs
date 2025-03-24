using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoID { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        public DateTime FechaPedido { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente";

        [Required]
        public decimal Total { get; set; }

        public Usuario Usuario { get; set; }
    }
}
