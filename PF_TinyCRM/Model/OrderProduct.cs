using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Model
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
