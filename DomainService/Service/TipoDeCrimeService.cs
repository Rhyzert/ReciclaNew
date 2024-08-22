using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using DomainService.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class TipoDeCrimeService : ITipoDeCrimeService
    {
        public readonly ITipoDeCrimeRepository _tipoDeCrimeRepository;

        public TipoDeCrimeService(ITipoDeCrimeRepository tipoDeCrimeRepository)
        {
            _tipoDeCrimeRepository = tipoDeCrimeRepository;
        }

            public List<itemColeta> GetTipoDeCrime()
            {
                return _tipoDeCrimeRepository.GetTipoDeCrime();
            }

            public itemColeta GetTipoDeCrimeById(int id)
            {
                return _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
            }

            public void InsertTipoDeCrime(itemColeta tipoDeCrime)
            {
            _tipoDeCrimeRepository.InsertTipoDeCrime(tipoDeCrime);
            }

            public void UpdateTipoDeCrime(itemColeta tipoDeCrime)
            {
                _tipoDeCrimeRepository.UpdateTipoDeCrime(tipoDeCrime);
            }

            public void DeleteTipoDeCrime(int id)
            {

                var tipoDeCrime = _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
                if (tipoDeCrime == null)
                    throw new Exception("Tipo De Crime Não Existe.");

                _tipoDeCrimeRepository.DeleteTipoDeCrime(tipoDeCrime);
            }
    }
}
