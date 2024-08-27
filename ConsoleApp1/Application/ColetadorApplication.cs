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
    public class ColetadorApplication : IColetadorApplication
    {
        public readonly IColetadorService _coletadorService;

        public ColetadorApplication(IColetadorService coletadorService)
        {
            _coletadorService = coletadorService;
        }
        public List<Coletador> GetColetadors()
        {
            return _coletadorService.GetColetadores();
        }

        public Coletador GetColetador(int id)
        {
            return _coletadorService.GetColetador(id);
        }

        public void InsertColetador(Coletador Coletador)
        {
            _coletadorService.InsertColetador(Coletador);
        }

        public void UpdateColetador(Coletador Coletador)
        {
            _coletadorService.UpdateColetador(Coletador);
        }

        public void DeleteColetador(int id)
        {
            _coletadorService.DeleteColetador(id);
        }


    }
}
