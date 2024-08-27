
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
    public class TipoReciclavelRepositorySqlServer : ITipoReciclavelRepository
    {

        private readonly SqlContext _context;

        public TipoReciclavelRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public TipoReciclavel GetTipoReciclavel(int id)
        {
            try
            {
                return _context.TipoReciclaveis.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<TipoReciclavel> GetTiposReciclaveis()
        {
            try
            {
                return _context.TipoReciclaveis.ToList();
            }
            catch (Exception ex) {
                throw ex;
            }

        }

        public void InsertTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.TipoReciclaveis.Add(tipoReciclavel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.Entry(tipoReciclavel).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteTipoReciclavel(TipoReciclavel tipoReciclavel)
        {
            try
            {
                _context.Set<TipoReciclavel>().Remove(tipoReciclavel);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
