
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ITipoReciclavelRepository
    {
        public TipoReciclavel GetTipoReciclavel(int id);
        public List<TipoReciclavel> GetTiposReciclaveis();
        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel);
        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel);
        public void DeleteTipoReciclavel(TipoReciclavel tipoReciclavel);
    }
}
