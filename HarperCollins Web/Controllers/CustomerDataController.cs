using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using HarperCollins.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

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
            return Mapper.Map<IEnumerable<CustomerData>>(customerDatas);
        }
    }
}