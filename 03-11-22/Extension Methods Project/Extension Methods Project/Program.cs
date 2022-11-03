namespace Extension_Methods_Project
{
    public class Program
    {
        public static void Main()
        {
            //DemoClass demoClass = new DemoClass();
            //demoClass.Test1();
            //demoClass.Test2();
            //// demoClass.Test3();  //though the method Test3 in DemoClassExtension is static it becomes non static after binding it to i.e extending using this keyword
            //DemoClass2 demoClass2 = new DemoClass2();
            //demoClass2.Test3();


            //Adding Extension method Factorial to Int32 struct
            //int number=56;
            //long factorial=number.Factorial();
            //Console.WriteLine($"Factorial Of number {number}:{factorial}");

            //Adding Extension Method ProperCase (Each words first alphabet in string will be capitalized and remaining will be lower case) in String class
            //string text = "how Are yOU";
            //string ProperString=text.ToProper();
            //Console.WriteLine(ProperString);  //Hoe 


            //Adding Extension method IsPrime to Int32 struct
            Console.WriteLine(5.IsPrime());
            

        }
    }
}
