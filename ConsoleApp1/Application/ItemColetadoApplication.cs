using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class ItemColetadoApplication : IItemColetadoApplication
    {
        public readonly IItemColetadoService _itemColetadoService;

        public ItemColetadoApplication(IItemColetadoService itemColetadoService)
        {
            _itemColetadoService = itemColetadoService;
        }

        public ItemColetado GetItemColetado(int id)
        {
            return _itemColetadoService.GetItemColetado(id);
        }

        public List<ItemColetado> GetItensColetados()
        {
            return _itemColetadoService.GetItensColetados();
        }

        public void InsertItemColetado(ItemColetado itemColetado)
        {
            _itemColetadoService.InsertItemColetado(itemColetado);
        }

        public void UpdateItemColetado(ItemColetado itemColetado)
        {
            _itemColetadoService.UpdateItemColetado(itemColetado);
        }

        public void DeleteItemColetado(int id)
        {
            _itemColetadoService.DeleteItemColetado(id);
        }

        
    }
}
