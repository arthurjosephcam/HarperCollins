using HarperCollins.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Repository
{
    public interface ICustomerDataRepository
    {
        Task<IEnumerable<CustomerData>> GetCustomerDatas();
        CustomerData UpdateCustomerData(CustomerData CustomerData);
        CustomerData AddCustomerData(CustomerData CustomerData);
        void DeleteCustomerData(CustomerData CustomerData);

        Task<CustomerData> GetCustomerData(Int32 CustomerNumber);

    }
}
