using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_iComparable_and_IComparer
{
    public class Student:IComparable<Student>
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public double Grade { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Id > other.Id)
                return 1;
            else if (this.Id < other.Id)
                return -1;
            else
                return 0;
        }
    }
}
