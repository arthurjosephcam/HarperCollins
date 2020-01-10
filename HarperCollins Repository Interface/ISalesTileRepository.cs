using HarperCollins.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Repository
{
    public interface ISalesTileRepository
    {
        Task<IEnumerable<SalesTile>> GetSalesTileAsync();
        
        SalesData UpdateSalesTile(SalesTile SalesTile);
        SalesData AddSalesTile(SalesTile SalesTile);
        void DeleteSalesTile(SalesTile SalesTile);

    }
}
