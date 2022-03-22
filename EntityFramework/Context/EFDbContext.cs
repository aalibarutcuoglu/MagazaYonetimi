using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Context
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
        {
            Database.Connection.ConnectionString = "server=101-00;database=EntityFrameworkOrnekDB;uid=sa;pwd=1234";
            //"server=101-00;database=EntityFrameworkOrnekDB;Trusted_Connection=true"
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Ogretmen> Ogretmen { get; set; }

    }
}
