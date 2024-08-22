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
    public class DenunciaService : IItemColetadoService
    {
        public readonly IItemColetadoRepository _denunciaRepository;

        public DenunciaService(IItemColetadoRepository denunciasRepository)
        {
            _denunciaRepository = denunciasRepository;
        }

            public List<Coleta> GetDenuncia()
            {
                return _denunciaRepository.GetDenuncias();
            }

            public Coleta GetDenunciaById(int id)
            {
                return _denunciaRepository.GetDenunciasById(id);
            }

            public void InsertDenuncia(Coleta denuncia)
            {
            _denunciaRepository.InsertDenuncias(denuncia);
            }

            public void UpdateDenuncia(Coleta denuncia)
            {
                _denunciaRepository.UpdateDenuncias(denuncia);
            }

            public void DeleteDenuncia(int id)
            {

                var denuncia = _denunciaRepository.GetDenunciasById(id);
                if (denuncia == null)
                    throw new Exception("Essa denuncia Não Existe.");

                _denunciaRepository.DeleteDenuncias(denuncia);
            }

    }
}
