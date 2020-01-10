using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository;
using HarperCollins.Service.Models;

namespace HarperCollins.Service
{
    public class SalesDataService : ISalesDataService
    {

        private readonly IUnitOfWork UnitOfWork;
        public SalesDataService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public  SalesData AddSalesData(SalesData SalesData)
        {
            var result =  UnitOfWork.SalesDataRepository.AddSalesData(Mapper.Map<Repository.Models.SalesData>(SalesData));
            return Mapper.Map<SalesData>(result);
        }

        public Boolean BulkAddSalesData(IEnumerable<SalesData> SalesDatas)
        {

            foreach(var salesData in SalesDatas)
            {
                UnitOfWork.SalesDataRepository.AddSalesData(Mapper.Map<Repository.Models.SalesData>(salesData));
            }

            return true;
        }

        public void DeleteSalesData(SalesData SalesData)
        {
            UnitOfWork.SalesDataRepository.DeleteSalesData(Mapper.Map<Repository.Models.SalesData>(SalesData));
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasAsync()
        {
            var result = await UnitOfWork.SalesDataRepository.GetSalesDatasAsync();
            return Mapper.Map<IEnumerable<SalesData>>(result);
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasByCustomerNumber(int CustomerNumber)
        {
            var result = await UnitOfWork.SalesDataRepository.GetSalesDatasByCustomerNumber(CustomerNumber);
            return Mapper.Map<IEnumerable<SalesData>>(result);
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasByISBN(string ISBN)
        {
            var result = await UnitOfWork.SalesDataRepository.GetSalesDatasByISBN(ISBN);
            return Mapper.Map<IEnumerable<SalesData>>(result);
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasByStatus(string Status)
        {
            var result = await UnitOfWork.SalesDataRepository.GetSalesDatasByStatus(Status);
            return Mapper.Map<IEnumerable<SalesData>>(result);
        }

        public SalesData UpdateSalesData(SalesData SalesData)
        {
            var result = UnitOfWork.SalesDataRepository.UpdateSalesData(Mapper.Map<Repository.Models.SalesData>(SalesData));
            return Mapper.Map<SalesData>(result);
        }
    }
}
