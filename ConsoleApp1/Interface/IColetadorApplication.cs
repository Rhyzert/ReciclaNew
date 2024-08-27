using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IColetadorApplication
    {

        Coletador GetColetador(int id);
        List<Coletador> GetColetadores();
        void InsertColetador(Coleta coletador);
        void UpdateColetador(Coleta coletador);
        void DeleteColetador(int id);
    }
}
