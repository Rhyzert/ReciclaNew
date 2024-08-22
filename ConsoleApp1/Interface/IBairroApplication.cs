using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IBairroApplication
    {
        Bairro GetBairro(int id);
        List<Bairro> GetBairros();
        void InsertBairro(Bairro bairro);
        void UpdateBairro(Bairro bairro);
        void DeleteBairro(int id);
    }
}
