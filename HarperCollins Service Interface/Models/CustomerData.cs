using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Service.Models
{
    public class CustomerData
    {
        public Int32 CustomerNumber { get; set; }
        public String CustomerName { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String AddressLine3 { get; set; }

        public ICollection<SalesData> Sales { get; set; }
    }
}
