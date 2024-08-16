using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaNew.Domain.Entidades
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Distrito { get; set; }
    }
}
