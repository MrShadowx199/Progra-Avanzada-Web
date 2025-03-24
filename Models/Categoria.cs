using System.ComponentModel.DataAnnotations;

namespace AspnetCoreMvcFull.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreCategoria { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }
    }
}
