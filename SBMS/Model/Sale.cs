using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Date { get; set; }
        public double LoyalityPoint { get; set; }
    }
}
