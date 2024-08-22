
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IItemColetadoRepository
    {
        public List<ItemColetado> GetItensColetados();
        public ItemColetado GetItemColeado(int id);
        public void InsertColeta(ItemColetado coleta);
        public void UpdateColeta(ItemColetado coleta);
        public void DeleteColeta(ItemColetado coleta);
    }
}
