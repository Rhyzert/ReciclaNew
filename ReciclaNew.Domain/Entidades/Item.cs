using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaNew.Domain.Entidades
{
    [Table("Itens")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Material { get; set; }
    }
}
