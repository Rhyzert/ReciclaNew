using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface ITipoReciclavelService
    {
        TipoReciclavel GetTipoReciclavel(int id);
        List<TipoReciclavel> GetTiposReciclaveis();
        void InsertTipoReciclavel(TipoReciclavel tipoReciclavel);
        void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel);
        void DeleteTipoReciclavel(int id);

    }
}
