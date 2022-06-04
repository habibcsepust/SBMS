using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class Stock
    {
        public string SL { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public string ManufacturedDate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }
    }
}
