using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Core.Entities
{
    [Table("Product")]
    public class ProductsEntity
    {
        [Key]
        public int ID { get; set; }
        public string? Descripcion { get; set; }
        public Tipo? Tipo { get; set; }
        public int Valor { get; set; }
        public DateTime FechaCompra { get; set; }
        public Estado? Estado { get; set; }
    }

    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
    }

    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
