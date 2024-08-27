using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    [Table("TipoReciclaveis")]
    public class TipoReciclavel
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Peso { get; set; }
        public string Descricao { get; set; }

    }
}
