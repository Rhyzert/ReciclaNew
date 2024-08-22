
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
        public Coleta GetColeta(int id);
        public List<Coleta> GetColetas();
        public void InsertColeta(Coleta coleta);
        public void UpdateColeta(Coleta coleta);
        public void DeleteColeta(Coleta coleta);
    }
}
