using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.ViewModel
{
    public class SalesView
    {
        public string SL { get; set; }
        public int Id { get; set; }
        public string Date { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public double SoldQty { get; set; }
        public double MRP { get; set; }
        public double TotalMRP { get; set; }
        public double CP { get; set; }
        public double Profit { get; set; }
    }
}
