using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReciclaNew.Domain.Entidades
{
    [Table("Coletas")]
    public class Coleta
    {
        [Key]
        public int Id { get; set; }
        public string Veiculo { get; set; }
        public string Placa { get; set; }
        public string QuantidadeObjetos { get; set; }
    }
}
