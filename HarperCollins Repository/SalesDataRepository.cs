﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<IEnumerable<SalesData>> GetSalesDatasAsync()
        {
            return await Context.SalesDatas
                 //.Include("SalesId")
                 //.Include("OrderDate")
                 //.Include("ISBN")
                 //.Include("CustomerNumber")
                 //.Include("OrderQuantity")
                 //.Include("OrderStatus")
                 .AsNoTracking()
                 .ToArrayAsync()
                 ;
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasByCustomerNumber(int CustomerNumber)
        {
            return await Context.SalesDatas
                .Where(sd => sd.CustomerNumber == CustomerNumber)
                .AsNoTracking()
                .ToArrayAsync()
                ;

           
        }

        public async Task<IEnumerable<SalesData>> GetSalesDatasByISBN(string ISBN)
        {
            return await Context.SalesDatas
                .Where(sd => sd.ISBN == ISBN)
                .AsNoTracking()
                .ToArrayAsync()
                ;
        }
        public async Task<IEnumerable<SalesData>> GetSalesDatasByStatus(string OrderStatus)
        {
            return await Context.SalesDatas
                 .Where(sd => sd.OrderStatus == OrderStatus)
                 .AsNoTracking()
                 .ToArrayAsync()
                 ;
        }

        public SalesData UpdateSalesData(SalesData SalesData)
        {
            Context.SalesDatas.Attach(SalesData);
            Context.Entry(SalesData).State = EntityState.Modified;
            return SalesData;
        }

        public SalesData AddSalesData(SalesData SalesData)
        {
            return Context.SalesDatas.Add(SalesData);

        }

        public void DeleteSalesData(SalesData SalesData)
        {
            Context.SalesDatas.Attach(SalesData);
            Context.Entry(SalesData).State = EntityState.Deleted;
        }


    }
}
