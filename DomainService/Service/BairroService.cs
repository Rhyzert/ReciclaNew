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
    public class BairroService : IBairroService
    {
        public readonly IBairroRepository _bairroRepository;

        public BairroService(IBairroRepository bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }
        public Bairro GetBairro(int id)
        {
            return _bairroRepository.GetBairro(id);
        }

        public List<Bairro> GetBairros()
        {
            return _bairroRepository.GetBairros();
        }

        public void InsertBairro(Bairro bairro)
        {
            _bairroRepository.InsertBairro(bairro);
        }

        public void UpdateBairro(Bairro bairro)
        {
        _bairroRepository.UpdateBairro(bairro);
        }

        public void DeleteBairro(int id)
        {

            var bairro = _bairroRepository.GetBairro(id);
            if (bairro == null)
                throw new Exception("Essa denuncia Não Existe.");

            _bairroRepository.DeleteBairro(bairro);
        }

    }
}
