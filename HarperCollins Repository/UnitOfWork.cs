using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext Context { get; set; }

        //public UnitOfWork(String ConnectionString, ILogger Logger)
        //{
        //    if (ConnectionString == null)
        //        throw new ArgumentNullException("ConnectionString", "ConnectionString cannot be null");

        //    this.Context = new DbContext(ConnectionString, Logger);

        //    InitializeRepositories();

        //}

        public UnitOfWork(String ConnectionString)
        {
            if (ConnectionString == null)
                throw new ArgumentNullException("ConnectionString", "ConnectionString cannot be null");

            this.Context = new DbContext(ConnectionString);

            InitializeRepositories();

        }

        #region generate properties
        private Lazy<ICustomerDataRepository> customerDataRepository;
        public ICustomerDataRepository CustomerDataRepository
        {
            get { return customerDataRepository.Value; }
        }

        private Lazy<ISalesDataRepository> salesDataRepository;
        public ISalesDataRepository SalesDataRepository
        {
            get { return salesDataRepository.Value; }
        }


        private Lazy<ITileDataRepository> tileDataRepository;
        public ITileDataRepository TileDataRepository
        {
            get { return tileDataRepository.Value; }
        }

        #endregion

        private void InitializeRepositories()
        {
            customerDataRepository = new Lazy<ICustomerDataRepository>(() => new CustomerDataRepository(Context));
            salesDataRepository = new Lazy<ISalesDataRepository>(() => new SalesDataRepository(Context));
            tileDataRepository = new Lazy<ITileDataRepository>(() => new TileDataRepository(Context));
        }




        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
