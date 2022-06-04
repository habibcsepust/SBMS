using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class SupplierPurchase
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string BillNo { get; set; }
        public int SupplierId { get; set; }
    }
}
