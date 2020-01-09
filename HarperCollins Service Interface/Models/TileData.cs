using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service.Models
{
    public class TileData
    {
        public String ISBN { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public String Format { get; set; }
        public Decimal ListPrice { get; set; }
        public ICollection<SalesData> Sales { get; set; }

    }
}
