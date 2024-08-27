
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ILixoRepository
    {
        public Lixo GetLixo(int id);
        public List<Lixo> GetLixos();
        public void InsertLixo(Lixo lixo);
        public void UpdateLixo(Lixo lixo);
        public void DeleteLixo(Lixo lixo);
    }
}
