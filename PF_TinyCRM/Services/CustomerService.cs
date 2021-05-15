using PF_TinyCRM.Data;
using PF_TinyCRM.Model;
using PF_TinyCRM.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PF_TinyCRM.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CrmDbContext dbContext = new CrmDbContext();
        
        public CustomerOptions CreateCustomer(CustomerOptions customerOptions)
        {
            Customer customer = new Customer
            {
                FirstName = customerOptions.FirstName,
                LastName = customerOptions.LastName,
                Phone = customerOptions.Phone,
                Email = customerOptions.Email,
                VatNumber = customerOptions.VatNumber,
                Address = customerOptions.Address,
                Dob = customerOptions.Dob,
                CreatedDate = DateTime.Now,
                TotalGross = 0
            };

            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();

            return new CustomerOptions
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                Email = customer.Email,
                VatNumber = customer.VatNumber,
                Dob = customer.Dob
            };
            
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerOptions> GetAllCustomers()
        {
            List<Customer> customers = dbContext.Customers.ToList();

            List<CustomerOptions> customerOptions = new List<CustomerOptions>();

            customers.ForEach(customer => customerOptions.Add(new CustomerOptions()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                Email = customer.Email,
                VatNumber = customer.VatNumber,
                Address = customer.Address,
                Dob = customer.Dob,
            }));

            return customerOptions;
        }

        public CustomerOptions GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerOptions UpdateCustomer(CustomerOptions customerOptions, int id)
        {
            throw new NotImplementedException();
        }
    }
}
