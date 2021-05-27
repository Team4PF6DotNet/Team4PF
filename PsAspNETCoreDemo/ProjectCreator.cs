using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsAspNETCoreDemo.Models
{
    public class ProjectCreator
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Dob { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
