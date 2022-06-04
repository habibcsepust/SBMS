using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class Sales_Details
    {
        public string SL { get; set; }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public double LoyalityPoint { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string SalesCode { get; set; }
        public string Product { get; set; }
        public double AvailableQuantity { get; set; }
        public double Quantity { get; set; }
        public double MRP { get; set; }
        public double TotalMRP { get; set; }
    }
}
