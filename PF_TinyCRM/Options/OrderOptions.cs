using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Options
{
    public class OrderOptions
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
