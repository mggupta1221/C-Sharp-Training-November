using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class DemoDictionary
    {

         private Dictionary<string, object> employees = new Dictionary<string, object>();

        public void AddEmployee1()
        {
            employees.Add("Eid", 100);
            employees.Add("EName", "Scott");
            employees.Add("Salary", 1000000);
            employees.Add("Dname","IT");
            employees.Add("Email","Scotttwatt@gmail.com");
            employees.Add("Location","Pune");
            employees.Add("Designation", "Analyst");
            employees.Add("Mgrid", 200);
        }
        public void RetreiveEmployee()
        {
            foreach(var employeeKey in employees.Keys)
            {
                Console.WriteLine($"{employeeKey}: {employees[employeeKey]}");
            }
        }
          
    }
}
