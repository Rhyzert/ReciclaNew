using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface ILixoService
    {
        Lixo GetLixo(int id);
        List<Lixo> GetLixos();
        void InsertLixo(Lixo lixo);
        void UpdateLixo(Lixo lixo);
        void DeleteLixo(int id);

    }
}
