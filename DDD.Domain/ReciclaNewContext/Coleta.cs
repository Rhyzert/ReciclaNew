using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    [Table("Coletas")]
    public class Coleta
    {     
        [Key]
        public int Id { get; set; }
        public Cidade Cidade { get; set; }
        public int CEP { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get;set; }
        public string? Bairro { get; set;}
        public string Complemento { get; set;}

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Longitude { get; set; }

    }
}
