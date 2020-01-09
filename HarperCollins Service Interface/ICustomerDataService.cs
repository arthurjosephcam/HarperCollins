using HarperCollins.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service
{
    public interface ICustomerDataService
    {
        Task<IEnumerable<CustomerData>> GetCustomerDatas();
        CustomerData UpdateCustomerData(CustomerData CustomerData);
        CustomerData AddCustomerData(CustomerData CustomerData);
        void DeleteCustomerData(CustomerData CustomerData);

        Task<CustomerData> GetCustomerData(Int32 CustomerNumber);

    }
}
