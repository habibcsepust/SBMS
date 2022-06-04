using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.ViewModel
{
    public class PurchaseModuleView
    {
        public int SL { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double StockQty { get; set; }
        public string Date { get; set; }
        public double CP { get; set; }
        public double SalesPrice { get; set; }
        public double Profit { get; set; }
    }
}
