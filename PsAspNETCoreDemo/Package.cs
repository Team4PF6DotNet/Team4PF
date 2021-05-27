using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Reward { get; set; }
        public decimal Fund_ammount { get; set; }
        //public List<FundingPackages> FundingPackages { get; set; }
    }
}
