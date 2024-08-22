
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class EstadoRepositorySqlServer : IEstadoRepository
    {

        private readonly SqlContext _context;

        public EstadoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Estado GetEstado(int id)
        {
            return _context.Estado.Find(id);
        }

        public List<Estado> GetEstados()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Estado.ToList();

        }

        public void InsertEstado(Estado estado)
        {
            try
            {
                _context.Coletas.Add(estado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void DeleteEstado(Estado estado)
        {
            try
            {
                _context.Set<Estado>().Remove(estado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
