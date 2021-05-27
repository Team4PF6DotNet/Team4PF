using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; } 
        public string Category { get; set; }
        public decimal FinancialProgress { get; set; }
        //public List<AllProjects> AllProjects { get; set; }
    }
}
