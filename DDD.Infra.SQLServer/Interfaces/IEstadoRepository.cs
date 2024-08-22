
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IEstadoRepository
    {
        public List<Estado> GetEstados();
        public Estado GetEstado(int id);
        public void InsertEstado(Estado estado);
        public void DeleteEstado(Estado estado);

    }
}
