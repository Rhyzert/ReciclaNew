
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ICidadeRepository
    {
        public List<Cidade> GetCidades();
        public Cidade GetCidade(int id);
        public void InsertCidade(Cidade cidade);
        public void UpdateCidade(Cidade cidade);
        public void DeleteCidade(Cidade cidade);
    }
}
