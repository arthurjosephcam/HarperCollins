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
            var result = UnitOfWork.CustomerDataRepository.AddCustomerData(Mapper.Map<Repository.Models.CustomerData>(CustomerData));
            return Mapper.Map<CustomerData>(result);
        }

        public void DeleteCustomerData(CustomerData CustomerData)
        {
           UnitOfWork.CustomerDataRepository.DeleteCustomerData(Mapper.Map<Repository.Models.CustomerData>(CustomerData));
        }

        public async Task<CustomerData> GetCustomerData(int CustomerNumber)
        {
            var result = await UnitOfWork.CustomerDataRepository.GetCustomerData(CustomerNumber);
            return Mapper.Map<CustomerData>(result);
        }

        public async Task<IEnumerable<CustomerData>> GetCustomerDatas()
        {
            var result = await UnitOfWork.CustomerDataRepository.GetCustomerDatas();
            return Mapper.Map<IEnumerable<CustomerData>>(result);
        }

        public async Task<IEnumerable<CustomerData>> SearchCustomer(String Keyword)
        {
            var result = await UnitOfWork.CustomerDataRepository.SearchCustomers(Keyword);
            return Mapper.Map<IEnumerable<CustomerData>>(result);
        }

        public CustomerData UpdateCustomerData(CustomerData CustomerData)
        {
            var result = UnitOfWork.CustomerDataRepository.UpdateCustomerData(Mapper.Map<Repository.Models.CustomerData>(CustomerData));
            return Mapper.Map<CustomerData>(result);
        }
    }
}
