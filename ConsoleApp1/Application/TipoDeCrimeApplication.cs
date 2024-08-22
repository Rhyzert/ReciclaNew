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
    public class TipoDeCrimeApplication : IBairroApplication
    {
        public readonly ITipoDeCrimeService _tipoDeCrimeService;

        public TipoDeCrimeApplication(ITipoDeCrimeService tipoDeCrimeService)
        {
            _tipoDeCrimeService = tipoDeCrimeService;
        }
        public List<itemColeta> GetTipoDeCrime()
        {
            return _tipoDeCrimeService.GetTipoDeCrime();
        }

        public itemColeta GetTipoDeCrimeById(int id)
        {
            return _tipoDeCrimeService.GetTipoDeCrimeById(id);
        }

        public void InsertTipoDeCrime(itemColeta tipoDeCrime)
        {
            _tipoDeCrimeService.InsertTipoDeCrime(tipoDeCrime);
        }

        public void UpdateTipoDeCrime(itemColeta tipoDeCrime)
        {
            _tipoDeCrimeService.UpdateTipoDeCrime(tipoDeCrime);
        }

        public void DeleteTipoDeCrime(int id)
        {
            _tipoDeCrimeService.DeleteTipoDeCrime(id);
        }
    }
}
