
using DDD.Domain.ReportRadarContext;
using DDD.Domain.UserManagementContext;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.SQLServer
{
    public class SqlContext : DbContext
    {

        //https://balta.io/blog/ef-crud
        //https://jasonwatmore.com/post/2022/03/18/net-6-connect-to-sql-server-with-entity-framework-core

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ReciclaNew");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().UseTpcMappingStrategy();
            /* modelBuilder.Entity<ClienteFuncionario>().UseTpcMappingStrategy();*/
            //https://learn.microsoft.com/pt-br/ef/core/modeling/inheritance
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ItemColetado> ItensColetados { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Coleta> Coletas { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Coletador> Coletadores { get; set; }
        public DbSet<TipoReciclavel> TipoReciclaveis { get; set; }
        public DbSet<Lixo> Lixos { get; set; }
    }
}
