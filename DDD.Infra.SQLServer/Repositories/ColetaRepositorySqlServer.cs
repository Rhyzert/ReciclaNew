
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
    public class ColetaRepositorySqlServer : IColetaRepository
    {

        private readonly SqlContext _context;

        public ColetaRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Coleta GetColeta(int id)
        {
            try
            {
                return _context.Coletas.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Coleta> GetColetas()
        {
            try
            {
                return _context.Coletas.ToList();
            }
            catch (Exception ex) { 
                throw ex
            }

        }

        public void InsertColeta(Coleta coleta)
        {
            try
            {
                _context.Coletas.Add(coleta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateColeta(Coleta denunciasConfirm)
        {
            try
            {
                _context.Entry(denunciasConfirm).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
