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
    public class BairroApplication : IBairroApplication
    {
        public readonly IBairroService _bairroService;

        public BairroApplication(IBairroService bairroService)
        {
            _bairroService = bairroService;
        }

        public Bairro GetBairro(int id)
        {
            return _bairroService.GetBairro(id);
        }
        public List<Bairro> GetBairros()
        {
            return _bairroService.GetBairros();
        }

        public void InsertBairro(Bairro bairro)
        {
            _bairroService.InsertBairro(bairro);
        }

        public void UpdateBairro(Bairro bairro)
        {
            _bairroService.UpdateBairro(bairro);
        }

        public void DeleteBairro(int id)
        {
            _bairroService.DeleteBairro(id);
        }

        
    }
}
