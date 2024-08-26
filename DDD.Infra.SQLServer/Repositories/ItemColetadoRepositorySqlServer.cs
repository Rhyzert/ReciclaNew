
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
    public class ItemColetadoRepositorySqlServer : IItemColetadoRepository
    {

        private readonly SqlContext _context;

        public ItemColetadoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }



        public ItemColetado GetItemColetado(int id)
        {
            return _context.ItensColetados.Find(id);
        }

        public List<ItemColetado> GetItensColetados()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.ItensColetados.ToList();

        }

        public void InsertItem(ItemColetado itemColetado)
        {
            try
            {
                _context.ItensColetados.Add(itemColetado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateItem(ItemColetado itemColetado)
        {
            try
            {
                _context.Entry(itemColetado).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteItem(ItemColetado itemColetado)
        {
            try
            {
                _context.Set<ItemColetado>().Remove(itemColetado);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
