using GenericDemo;
using System;
using System.Xml.Serialization;

namespace DemoGeneric
{
    public class Program
    {
        public static void Main()
        {

            //Running Demo 1
            Console.WriteLine("Running Demo1");

            GenericDemo1 demo1 = new GenericDemo1();
            bool valid=demo1.CompareValues<float>(12.34f, 12.34f);
            bool valid2 = demo1.CompareValues<string>("ABC", "ABC");
            Console.WriteLine(valid);
            Console.WriteLine(valid2);
            Console.WriteLine();
            //Running demo 2
            Console.WriteLine("Running Demo2");

            GenericDemo2 demo2 =new GenericDemo2();
            demo2.Addition<int>(432, 654);
            demo2.Subtract<double>(432.9876, 65.334);
            demo2.Multiply<char>('a', 'b');
            demo2.Divide(432, 654);
            Console.WriteLine();
            //Running demo 3
            Console.WriteLine("Running Demo3");
            GenericDemo3<int> demo3Int =new  GenericDemo3<int>();
            demo3Int.Addition(56, 98);
            demo3Int.Subtract(56, 98);
            demo3Int.Multiply(56, 98);




        }
    }
}