using PF_TinyCRM.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace PF_TinyCRM.Services
{
    interface ICustomerService
    {
        public CustomerOptions CreateCustomer(CustomerOptions customerOptions);
        public List<CustomerOptions> GetAllCustomers();
        public CustomerOptions GetCustomerById(int id);
        public CustomerOptions UpdateCustomer(CustomerOptions customerOptions, int id);
        public bool DeleteCustomer(int id);
    }
}
