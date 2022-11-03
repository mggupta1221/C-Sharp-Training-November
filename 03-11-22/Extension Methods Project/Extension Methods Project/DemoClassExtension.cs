using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Project
{
    public static class DemoClassExtension
    {

        //this is not considered as parameter to pass it is only to bind and must be first parameter of an extension method
        public static void Test3(this DemoClass demoClass)  //test3 method belongs to this class Democlass
        {
            Console.WriteLine("Test3");
        }
        //public static void Test3(this object demoClass)  //test3 method belongs to this class object and object is base class so it can be called by any class whose base is object
        //{
        //    Console.WriteLine("Test3");
        //}

    }
}
