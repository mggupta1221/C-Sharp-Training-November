using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericDemo1
    {
        public bool CompareValues<T>(T a, T b) // no need to write diffrent methods for diffrent type of data
        {

            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
    }
}
