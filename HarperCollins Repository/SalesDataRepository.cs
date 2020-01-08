using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository.Models;

namespace HarperCollins.Repository
{
    public class SalesDataRepository : ISalesDataRepository
    {
        DbContext Context { get; set; }
        internal SalesDataRepository(DbContext Context) 
        {
            this.Context = Context;
        }

        public Task<IEnumerable<SalesData>> GetSalesDatas()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalesData>> GetSalesDatasByCustomerNumber(int CustomerNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SalesData>> GetSalesDatasByISBN(string ISBN)
        {
            throw new NotImplementedException();
        }

        public SalesData UpdateSalesData(SalesData SalesData)
        {
            throw new NotImplementedException();
        }

        public SalesData AddSalesData(SalesData SalesData)
        {
            throw new NotImplementedException();
        }

        public void DeleteSalesData(SalesData SalesData)
        {
            throw new NotImplementedException();
        }
    }
}
