
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
    public class BairroRepositorySqlServer : IBairroRepository
    {

        private readonly SqlContext _context;

        public BairroRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Bairro GetBairro(int id)
        {
            return _context.Bairros.Find(id);
        }

        public List<Bairro> GetBairros()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Bairros.ToList();

        }
       
    }
}
