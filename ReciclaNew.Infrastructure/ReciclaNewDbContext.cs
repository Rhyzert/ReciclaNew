using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReciclaNew.Domain.Entidades;

namespace ReciclaNew.Infrastructure
{
    public class ReciclaNewDbContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<Coleta> Coletas { get; set; }

        public ReciclaNewDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "Postgresql") 
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

/*            switch (typeDatabase) 
            {
                case "PostgreSql": 
                    optionsBuilder.UseNpgsql(connectionString);
                    break;
                    

            }*/
        }

    }
}
