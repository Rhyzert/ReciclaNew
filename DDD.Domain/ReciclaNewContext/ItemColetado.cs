using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    [Table("ItensColetados")]
    public class ItemColetado
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Volume { get; set; }
        public string PesoAproximado { get; set; }

    }
}
