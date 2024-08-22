
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
        public ItemColetado GetItemColetado(int id);
        public void InsertItem(ItemColetado coleta);
        public void UpdateItem(ItemColetado coleta);
        public void DeleteItem(ItemColetado coleta);
    }
}
