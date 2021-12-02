using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsConsoleApp1
{
    class MyDataContext : DbContext
    {
        internal static string connectionString = @"data source = (LocalDB)\MSSQLLocalDB;attachdbfilename=C:\Users\a.zaigraev\Documents\Drm.mdf;integrated security = True; connect timeout = 30; MultipleActiveResultSets=True;App=EntityFramework";
        public MyDataContext() : base(connectionString)
        { }
        public DbSet<T_Otbor> otbors { get; set; }
        public DbSet<T_Department> departments { get; set; }

        public DbSet<T_Departmentnew> departmentnews { get; set; }
        public DbSet<T_Terminal> terminals { get; set; }

        public DbSet<T_Terminalnew> terminalnews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
