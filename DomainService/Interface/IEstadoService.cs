using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface IEstadoService
    {
        
        List<Estado> GetEstados();
        Estado GetEstado(int id);
        void InsertEstado(Estado estado);
        void DeleteEstado(int id);


    }
}
