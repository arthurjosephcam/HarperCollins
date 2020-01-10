using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<IEnumerable<CustomerData>> GetCustomerDatas()
        {
            try {
                var ret = await Context.CustomerDatas
                    //.Include("Sales")
                  .AsNoTracking()
                  .ToArrayAsync()
                  
                  ;

                return ret;

            }
            catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            
        }

        public CustomerData UpdateCustomerData(CustomerData CustomerData)
        {
            Context.CustomerDatas.Attach(CustomerData);
            Context.Entry(CustomerData).State = EntityState.Modified;
            return CustomerData;
        }

        public CustomerData AddCustomerData(CustomerData CustomerData)
        {
            return Context.CustomerDatas.Add(CustomerData);
        }

        public void DeleteCustomerData(CustomerData CustomerData)
        {
            Context.CustomerDatas.Attach(CustomerData);
            Context.Entry(CustomerData).State = EntityState.Deleted;
           // return CustomerData;
        }

        public async Task<CustomerData> GetCustomerData(int CustomerNumber)
        {
            return await Context.CustomerDatas
                .Where(cd => cd.CustomerNumber == CustomerNumber)
                .FirstOrDefaultAsync()
               ;
        }
    }
}
