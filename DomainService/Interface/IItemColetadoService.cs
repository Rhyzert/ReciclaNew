using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface IItemColetadoService
    {
        ItemColetado GetItemColetado(int id);
        List<ItemColetado> GetItensColetados();
        void InsertItem(ItemColetado itemColetado);
        void UpdateItem(ItemColetado itemColetado);
        void DeleteItem(int id);

    }
}
