using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class Sales_Amount
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public double GrandTotal { get; set; }
        public double Discount { get; set; }
        public double DiscountAmount { get; set; }
        public double PayableAmount { get; set; }
    }
}
