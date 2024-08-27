
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
    public class ColetadorRepositorySqlServer : IColetadorRepository
    {

        private readonly SqlContext _context;

        public ColetadorRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Coletador GetColetador(int id)
        {
            try
            {
                return _context.Coletadores.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Coletador> GetColetadores()
        {
            try
            {
                return _context.Coletadores.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void InsertColetador(Coletador coletador)
        {
            try
            {
                _context.Coletadores.Add(coletador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateColetador(Coletador coletador)
        {
            try
            {
                _context.Entry(coletador).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteColetador(Coletador coletador)
        {
            try
            {
                _context.Set<Coletador>().Remove(coletador);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
