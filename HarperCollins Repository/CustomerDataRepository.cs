using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository.Models;

namespace HarperCollins.Repository
{
    public class CustomerDataRepository : ICustomerDataRepository
    {
        DbContext Context { get; set; }
        internal CustomerDataRepository(DbContext Context)
        {
            this.Context = Context;
        }

        public Task<IEnumerable<CustomerData>> GetCustomerDatas()
        {
            throw new NotImplementedException();
        }

        public CustomerData UpdateCustomerData(CustomerData CustomerData)
        {
            throw new NotImplementedException();
        }

        public CustomerData AddCustomerData(CustomerData CustomerData)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerData(CustomerData CustomerData)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerData> GetCustomerData(int CustomerNumber)
        {
            throw new NotImplementedException();
        }
    }
}
