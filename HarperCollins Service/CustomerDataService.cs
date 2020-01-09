using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository;
using HarperCollins.Service.Models;

namespace HarperCollins.Service
{
    public class CustomerDataService : ICustomerDataService
    {
        private readonly IUnitOfWork UnitOfWork;
        public CustomerDataService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
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

        public Task<IEnumerable<CustomerData>> GetCustomerDatas()
        {
            throw new NotImplementedException();
        }

        public CustomerData UpdateCustomerData(CustomerData CustomerData)
        {
            throw new NotImplementedException();
        }
    }
}
