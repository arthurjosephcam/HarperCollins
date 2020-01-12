using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.WebApplication.Models
{
    public class SalesData
    {
        //Flattened the class, for UI Display purposes.

        public Guid SalesId { get; set; }
        public DateTime OrderDate { get; set; }

        public Int32 OrderQuantity { get; set; }
        public String OrderStatus { get; set; }

        public Int32 CustomerNumber {get; set;}
       // public CustomerData CustomerData { get; set; }
        public String CustomerName { get; set; }

        public String ISBN { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Format { get; set; }
        public Decimal ListPrice { get; set; }
       // public TileData TileData { get; set; }
    }
}
