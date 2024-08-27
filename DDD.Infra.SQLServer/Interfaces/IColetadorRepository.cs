
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IColetadorRepository
    {
        public List<Coletador> GetColetadores();
        public Coletador GetColetador(int id);
        public void InsertColetador(Coletador coletador);
        public void UpdateColetador(Coletador coletador);
        public void DeleteColetador(Coletador coletador);

    }
}
