using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DomainService.Interface;
using DomainService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class CidadeApplication : ICidadeApplication
    {
        public readonly ICidadeService _cidadeService;

        public CidadeApplication(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }
        public List<Cidade> GetCidades()
        {
            return _cidadeService.GetCidade();
        }

        public Cidade GetCidade(int id)
        {
            return _cidadeService.GetCidadeById(id);
        }

        public void InsertCidade(Cidade cidade)
        {
            _cidadeService.InsertCidade(cidade);
        }
        public void DeleteCidade(int id)
        {
            _cidadeService.DeleteCidade(id);
        }

    }
}
