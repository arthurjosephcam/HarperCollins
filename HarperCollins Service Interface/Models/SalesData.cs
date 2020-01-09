using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service.Models
{
    public class SalesData
    {
        public Guid SalesId { get; set; }
        public DateTime OrderDate { get; set; }

        public Int32 OrderQuantity { get; set; }
        public String OrderStatus { get; set; }

        public Int32 CustomerNumber {get; set;}
        public CustomerData CustomerData { get; set; }

        public String ISBN { get; set; }
        public TileData TileData { get; set; }
    }
}
