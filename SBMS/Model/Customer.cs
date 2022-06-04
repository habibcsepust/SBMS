using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class Customer
    {
        public string SL { set; get; }
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Contact { set; get; }
        public double LoyaltyPoint { set; get; }

        public Customer()
        {
            LoyaltyPoint = 0;
        }
    }
}
