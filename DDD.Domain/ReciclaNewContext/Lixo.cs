using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    [Table("Lixos")]
    public class Lixo
    {     
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string? Cor { get; set; }
        public float? Peso { get; set; }
        public TipoReciclavel Tipo { get;set; }

        public Lixo(string descricao, string cor,float peso, TipoReciclavel tipo)
        {
            Descricao = descricao;
            Cor = cor;
            Peso = peso;
            Tipo = tipo;
        }

    }
}
