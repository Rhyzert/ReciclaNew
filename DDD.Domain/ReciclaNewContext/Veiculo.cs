using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    [Table("Veiculos")]
    public class Veiculo
    {     
        [Key]
        public int Id { get; set; }
        public string? Modelo { get; set; }
        public string? Eixo { get; set; }
        public string? Placa { get; set; }
        public float? VolumeCarreta { get;set; }

    }
}
