using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using DomainService.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class CidadeService : ICidadeService
    {
        public readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public List<Cidade> GetCidade()
        {
            return _cidadeRepository.GetCidades();
        }

        public Cidade GetCidadeById(int id)
        {
            return _cidadeRepository.GetCidade(id);
        }

        public void InsertCidade(Cidade cidade)
        {
            _cidadeRepository.InsertCidade(cidade);
        }

        public void UpdateCidade(Cidade cidade)
        {
            _cidadeRepository.UpdateCidade(cidade);
        }

        public void DeleteCidade(int id)
        {

            var cidade = _cidadeRepository.GetCidade(id);
            if (cidade == null)
                throw new Exception("Essa cidade Não Existe.");

            _cidadeRepository.DeleteCidade(cidade);
        }
    }
}
