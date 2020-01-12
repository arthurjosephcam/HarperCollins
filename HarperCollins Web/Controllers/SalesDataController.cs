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
                var ret = Mapper.Map<IEnumerable<SalesData>>(salesDatas);
                return ret;
            }
            catch (Exception ex) { throw ex; }
            

        }


        [HttpPost("[action]")]
        public Boolean SaveSales([FromBody] IEnumerable<SalesData> salesDatas)
        {
            SalesDataService.BulkAddSalesData(Mapper.Map<IEnumerable<Service.Models.SalesData>>(salesDatas));
            return true;
        }



        [HttpGet("[action]")]
        public  Boolean TestCreateNew()
        {
            List<SalesData> salesDatas = new List<SalesData>();

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


            CustomerData cust2 = new CustomerData();
            cust2.CustomerNumber = 10000411;
            cust2.CustomerName = "WHITEHOTS INC";


            TileData tile2 = new TileData();
            tile2.ISBN = "9780007371464";

            SalesData sales2 = new SalesData();
            sales2.OrderDate = DateTime.Now;
            sales2.SalesId = Guid.NewGuid();
            sales2.OrderQuantity = 2;
            sales2.OrderStatus = "Preparing";
            sales2.ISBN = tile.ISBN;
            sales2.CustomerNumber = cust.CustomerNumber;


            salesDatas.Add(sales);
            salesDatas.Add(sales2);

            IEnumerable<SalesData> ss = salesDatas;
            SalesDataService.BulkAddSalesData(Mapper.Map<IEnumerable<Service.Models.SalesData>>(ss));

            return true;
            //var newSalesData =  SalesDataService.AddSalesData(Mapper.Map<Service.Models.SalesData>(sales));

            //return Mapper.Map<SalesData>(newSalesData);
        }

    }

}