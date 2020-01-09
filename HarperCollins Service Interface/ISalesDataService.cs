using HarperCollins.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service
{
    public interface ISalesDataService
    {
        Task<IEnumerable<SalesData>> GetSalesDatasAsync();
        Task<IEnumerable<SalesData>> GetSalesDatasByCustomerNumber(Int32 CustomerNumber);
        Task<IEnumerable<SalesData>> GetSalesDatasByISBN(String ISBN);
        Task<IEnumerable<SalesData>> GetSalesDatasByStatus(String ISBN);
        SalesData UpdateSalesData(SalesData SalesData);
        SalesData AddSalesData(SalesData SalesData);
        void DeleteSalesData(SalesData SalesData);

        //Task<SalesData> GetSalesData(Int32 CustomerNumber);
    }
}
