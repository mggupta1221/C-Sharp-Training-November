using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericDemo3 <T>
    {
        public void Addition(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 + dynamicValue2);
        }

        public void Subtract(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 - dynamicValue2);
        }

        public void Multiply(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 * dynamicValue2);
        }

        public void Divide(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 / dynamicValue2);
        }
    }
}
