using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenericDemo2
    {
        public void Addition <T>(T value1,T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 + dynamicValue2);
        }

        public void Subtract<T>(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 - dynamicValue2);
        }

        public void Multiply<T>(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 * dynamicValue2);
        }

        public void Divide<T>(T value1, T value2)
        {
            dynamic dynamicValue1 = value1;
            dynamic dynamicValue2 = value2;
            Console.WriteLine(dynamicValue1 / dynamicValue2);
        }

    }
}
