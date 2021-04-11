using Exemplo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Data
{
    public class ExemploContext : DbContext, IUnitOfWork
    {
        public ExemploContext(DbContextOptions<ExemploContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO Diferença destes dois métodos
            // modelBuilder.ApplyConfiguration(new BlogConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExemploContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }

        #region DB_SETS

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        #endregion DB_SETS

    }
}
