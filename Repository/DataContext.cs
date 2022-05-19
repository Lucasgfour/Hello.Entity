using Data.Model;
using Microsoft.EntityFrameworkCore;
using Repository.ModelMap;

namespace Repository {
    public class DataContext : DbContext {

        private string connectionString = "";

        public DbSet<Pessoa> pessoas { get; set; }

        public DataContext() {

            this.connectionString = RepositoryResolver.ConnectionString;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {

            options.UseMySql(this.connectionString, ServerVersion.AutoDetect(connectionString));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration<Pessoa>(new PessoaMap());

        }

    }
}
