using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoUsingUserDefinedDatatype
{
    public class CustomerRepository
    {
        List<Customer> customers = new List<Customer>();
        public void ShowCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Id} : {customer.Name} :{customer.Age} :{customer.AccountNumber} :{customer.Balance} :");
            }
        }

        public void Addcustomers()
        {
            
            customers.Add(new Customer() { Id = 1220, Name = "Scott", Age = 34, AccountNumber = 77893, Balance = 25505 });
            customers.Add(new Customer() { Id = 1221, Name = "Iris", Age = 24, AccountNumber = 34254, Balance = 5023 });
            customers.Add(new Customer() { Id = 1222, Name = "Jacob", Age = 36, AccountNumber = 34021, Balance = 55023 });
        }
    }
}
