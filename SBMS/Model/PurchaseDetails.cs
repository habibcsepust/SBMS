﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Model
{
    public class PurchaseDetails
    {
        public string SL { set; get; }
        public int Id { get; set; }
        public string BillNo { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpireDate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double MRP { get; set; }
        public string Remarks { get; set; }
    }
}
