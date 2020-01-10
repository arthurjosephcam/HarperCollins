using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using HarperCollins.WebApplication;
using HarperCollins.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace HarperCollins.Controllers
{
    [Route("api/[controller]")]
    public class SalesDataController : Controller
    {
        ISalesDataService SalesDataService;
        public SalesDataController(ISalesDataService SalesDataService)
        {
            this.SalesDataService = SalesDataService;
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<SalesData>> GetAllSales()
        {
            var salesDatas = await SalesDataService.GetSalesDatasAsync();

            try {
                return Mapper.Map<IEnumerable<SalesData>>(salesDatas);
            }
            catch (Exception ex) { throw ex; }
            

        }
    }

}