using System;
using PF_TinyCRM.Model;
using PF_TinyCRM.Options;
using PF_TinyCRM.Services;

namespace PF_TinyCRM
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerOptions customer = new CustomerOptions() { FirstName = "Anna", LastName = "Karenina" };
            ICustomerService customerService = new CustomerService();
            customerService.CreateCustomer(customer);

            CustomerOptions customer2 = new CustomerOptions() { FirstName = "Darya", LastName = "Alexandrova" };
            customerService.CreateCustomer(customer2);

        }
    }
}
