
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
    public class CidadeRepositorySqlServer : ICidadeRepository
    {

        private readonly SqlContext _context;

        public CidadeRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Cidade GetCidade(int id)
        {
            return _context.Cidades.Find(id);
        }

        public List<Cidade> GetCidades()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Cidades.ToList();

        }

        public void InsertCidade(Cidade cidade)
        {
            try
            {
                _context.Cidades.Add(cidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void DeleteCidade(Cidade cidade)
        {
            try
            {
                _context.Set<Cidade>().Remove(cidade);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
