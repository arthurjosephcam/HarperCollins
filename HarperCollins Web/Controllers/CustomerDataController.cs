using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using HarperCollins.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using HarperCollins.WebApplication;

namespace HarperCollins.Controllers
{
    [Route("api/[controller]")]
    public class CustomerDataController : Controller
    {
        ICustomerDataService CustomerDataService;
        public CustomerDataController(ICustomerDataService CustomerDataService)
        {
            this.CustomerDataService = CustomerDataService;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<CustomerData>> GetAllClients()
        {
            var customerDatas = await CustomerDataService.GetCustomerDatas();
            try
            {
                var ret = Mapper.Map<IEnumerable<CustomerData>>(customerDatas);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<CustomerData>> SearchClients(String Keyword)
        {
            var customerDatas = await CustomerDataService.SearchCustomer(Keyword);
            try
            {
                var ret = Mapper.Map<IEnumerable<CustomerData>>(customerDatas);
                return ret;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}