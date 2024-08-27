using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface IColetadorService
    {
        Coletador GetColetador(int id);
        List<Coletador> GetColetadores();
        void InsertColetador(Coletador coletador);
        void UpdateColetador(Coletador coletador);
        void DeleteColetador(int id);

    }
}
