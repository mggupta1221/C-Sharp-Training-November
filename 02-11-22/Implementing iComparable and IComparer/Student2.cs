using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//implementing comparer : it is implemented to sort if we do not have code
namespace Implementing_iComparable_and_IComparer
{
    public class Student2 : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {

           // return x.Name.CompareTo(y.Name);

            if (x. > y.Grade)
                return 1;
            else if(x.Grade < y.Grade)  
                return -1;
            return 0;
        }
    }
}
