using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface ICidadeApplication
    {
        Cidade GetCidade(int id);
        List<Cidade> GetCidades();       
        void InsertCidade(Cidade cidade);
        void DeleteCidade(int id);

    }
}
