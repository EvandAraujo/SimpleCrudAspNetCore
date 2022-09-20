using Microsoft.EntityFrameworkCore;
using SimpleCrudBackEndNetCore.Domain.Entities;
using SimpleCrudBackEndNetCore.Infra.EntityMappers;

namespace SimpleCrudBackEndNetCore.Infra.Context
{
    public class MicroServiceContext : DbContext
    {
        public MicroServiceContext(DbContextOptions<MicroServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new BrazilianUfMap());
        }
    }
}
