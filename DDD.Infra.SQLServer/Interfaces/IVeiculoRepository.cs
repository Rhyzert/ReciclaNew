
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IVeiculoRepository
    {

        public Veiculo GetVeiculo(int id);
        public List<Veiculo> GetVeiculos();
        public void InsertVeiculo(Veiculo veiculo);
        public void UpdateVeiculo(Veiculo veiculo);
        public void DeleteVeiculo(int id);

    }
}
