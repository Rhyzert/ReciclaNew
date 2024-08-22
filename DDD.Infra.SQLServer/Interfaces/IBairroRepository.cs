
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IBairroRepository
    {
        public List<Bairro> GetBairros();
        public Bairro GetBairro(int id);
        public void InsertBairro(Bairro bairro);
        public void UpdateBairro(Bairro bairro);
        public void DeleteBairro(Bairro bairro);

    }
}
