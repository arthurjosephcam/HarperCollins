using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service.Models
{
    public class SalesTile
    {
        public int SalesTileId { get; set; } 
        public Guid SalesId { get; set; }
        public SalesData SalesData { get; set; }

        public Int32 OrderQuantity { get; set; }

        public String ISBN { get; set; }
        public TileData TileData { get; set; }

    
    }
}
