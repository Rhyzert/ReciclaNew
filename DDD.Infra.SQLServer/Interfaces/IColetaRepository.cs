
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IColetaRepository
    {
        public List<Coleta> GetColetas();
        public Coleta GetColetaById(int id);
        public void InsertColetaConfirm(Coleta denunciasConfirm);
        public void UpdateColetaConfirm(Coleta denunciasConfirm);
        public void DeleteColetaConfirm(Coleta denunciasConfirm);
    }
}
