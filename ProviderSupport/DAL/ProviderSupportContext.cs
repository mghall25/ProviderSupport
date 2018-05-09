using ProviderSupport.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProviderSupport.DAL
{
    public class ProviderSupportContext : DbContext
    {
        // connection string to the database passed into the constructor
        public ProviderSupportContext() : base("ProviderSupportContext")
        {
        }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}