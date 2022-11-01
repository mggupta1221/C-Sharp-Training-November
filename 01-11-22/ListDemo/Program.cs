//Non generic collections are not type safe can store any value as object .Add(Object value)

//So we use Generic collections fot type safety List<T> Here t states the type

using System;
using System.Collections.Generic;

namespace DemoList
{
    public class ListDemo
    {

        

        public static void Main(){
            List<double> li = new List<double>();
            Console.Write("Capacity:");
            Console.WriteLine(li.Capacity);

            li.Add(42.5);
            li.Add(87.90);
            li.Add(87);
            li.Add(99.044);
            li.Add(56.34);
            li.Add(34.56);
            Console.Write("Capacity:");
            Console.WriteLine(li.Capacity);

            foreach (double value in li)
            {
                Console.Write(value+" ");
            }
            Console.Write("Capacity:");
            Console.WriteLine(li.Capacity);

            li.Remove(87);
            li.Remove(34.56);
            Console.WriteLine();
            foreach (double value in li)
            {
                Console.Write(value+" ");
            }
            Console.Write("Capacity:");
            Console.WriteLine(li.Capacity);

       


        }

    }
}