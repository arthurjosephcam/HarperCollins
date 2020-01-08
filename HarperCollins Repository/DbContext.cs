using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HarperCollins.Repository.Models;
using HarperCollins.Repository.Configurations;

namespace HarperCollins.Repository
{
    internal class DbContext : System.Data.Entity.DbContext
    {
        public DbContext(String ConnectionString, ILogger Logger) : base(ConnectionString)
        {
            InitializeContext();

            if (null != Logger)
            {
                this.Database.Log = s => Logger.Log(LogLevel.Information, s, null);
            }
        }
        public DbContext(String ConnectionString) : base(ConnectionString)
        {
            InitializeContext();
        }

        private void InitializeContext()
        {
            // Prevent any code first code from running
            Database.SetInitializer<DbContext>(null);

            // Prevent proxies of our POCOs
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

            // Disable Change tracking for performance
            Configuration.AutoDetectChangesEnabled = false;

            // Set the default timeout
            this.Database.CommandTimeout = 30;

            // Log SQL queries
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<SalesData> SalesDatas { get; set; }
        public DbSet<TileData> TileDatas { get; set; }
        public DbSet<CustomerData> CustomerDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Configurations.Add(new SalesDataConfiguration());
            ModelBuilder.Configurations.Add(new CustomerDataConfiguration());
            ModelBuilder.Configurations.Add(new TileDataConfiguration());
        }

        #region EF provider Service Fix
        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        #endregion
    }
}
