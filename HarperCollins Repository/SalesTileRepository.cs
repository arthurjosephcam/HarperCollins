using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository.Models;

namespace HarperCollins.Repository
{
    public class SalesTileRepository : ISalesTileRepository
    {
        DbContext Context { get; set; }
        internal SalesTileRepository(DbContext Context)
        {
            this.Context = Context;
        }
        public SalesData AddSalesTile(SalesTile SalesTile)
        {
            throw new NotImplementedException();
        }

        public void DeleteSalesTile(SalesTile SalesTile)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SalesTile>> GetSalesTileAsync()
        {
            return await Context.SalesTiles
                .AsNoTracking()
                .ToArrayAsync();
        }

        public SalesData UpdateSalesTile(SalesTile SalesTile)
        {
            throw new NotImplementedException();
        }
    }
}
