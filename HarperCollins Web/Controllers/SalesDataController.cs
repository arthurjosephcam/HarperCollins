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

        [HttpGet("[action]")]
        public  SalesData TestCreateNew()
        {

            CustomerData cust = new CustomerData();
            cust.CustomerNumber = 10000411;
            cust.CustomerName = "WHITEHOTS INC";


            TileData tile = new TileData();
            tile.ISBN = "9780007371464";

            SalesData sales = new SalesData();
            sales.OrderDate = DateTime.Now;
            sales.SalesId = Guid.NewGuid();
            sales.OrderQuantity = 2;
            sales.OrderStatus = "Pending";
            sales.ISBN = tile.ISBN;
            sales.CustomerNumber = cust.CustomerNumber;

            var newSalesData =  SalesDataService.AddSalesData(Mapper.Map<Service.Models.SalesData>(sales));

            return Mapper.Map<SalesData>(newSalesData);
        }

    }

}