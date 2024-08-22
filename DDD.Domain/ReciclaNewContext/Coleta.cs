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
    [Table("Coletas")]
    public class Coleta
    {     
        [Key]
        public int Id { get; set; }
        public Cidade Cidade { get; set; }
        public string CEP { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get;set; }
        public string? Bairro { get; set;}
        public string Complemento { get; set;}
        public string DataChegada { get; set;}
        public string DataSaida { get;set;}
        public Veiculo Veiculo { get; set;}

        public Coleta(Cidade cidade, string cep,string endereco, int numero, string bairro, string complemento, string datachegada, string datasaida, Veiculo veiculo)
        {
            Cidade = cidade;
            CEP = cep;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
            DataChegada = datachegada;
            DataSaida = datasaida;
            Veiculo = veiculo;
        }

    }
}
