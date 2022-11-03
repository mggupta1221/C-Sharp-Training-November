using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Practice
{
    public class Organization:IEnumerable
    {
        List<Employee> employees = new List<Employee>();
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this); //passing current class object i.e Organization object
        }

        public int Count { get { return employees.Count; } }


        public Employee this [int index]{

            get{return employees[index]; }
            
        }

    }
}
