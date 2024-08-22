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
    public class EstadoService : IEstadoService
    {
        public readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

            public List<Estado> GetEstados()
            {
                return _estadoRepository.GetEstados();
            }

            public Estado GetEstado(int id)
            {
                return _estadoRepository.GetEstado(id);
            }

            public void InsertEstado(Estado estado)
            {
                _estadoRepository.InsertEstado(estado);
            }

            public void DeleteEstado(int id)
            {

                var estado = _estadoRepository.GetEstado(id);
                if (estado == null)
                    throw new Exception("Tipo De Crime Não Existe.");

                _estadoRepository.DeleteEstado(estado);
            }
    }
}
