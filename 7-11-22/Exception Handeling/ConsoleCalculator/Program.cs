using System;
using System.Diagnostics;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain=AppDomain.CurrentDomain;

            WriteLine("Enter first number");
             int number1 = int.Parse(ReadLine());
           // bool isNumber1Valid=int.TryParse(ReadLine(), out number1);

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());
            //bool isnumber2Valid=int.TryParse(ReadLine(), out number2);

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();

            try
            {
                var calculator = new Calculator();
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine($"Operation was not Provided : {ex}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An Argument was Null : {ex}");
            }
            catch (CalculationOperationNotSupportedException ex)
            {
                WriteLine($"CalculationOperationNotSupportedException: '{ex.Operation}'");
                WriteLine(ex);
            }
            catch (CalculationException ex)
            {
                WriteLine($"CalculationException caught:{ex}");
                WriteLine(ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Sorry! Something Went Wrong!!! : {ex}");
            }
            finally
            {
                WriteLine("...................Finally...................");
            }
        }

        private static void DisplayResult(int result) => WriteLine($"Result is: {result}");
    }
}


// FROM C# 9 "Top-level statements":

//using ConsoleCalculator;
//using static System.Console;


//WriteLine("Enter first number");
//int number1 = int.Parse(ReadLine());

//WriteLine("Enter second number");
//int number2 = int.Parse(ReadLine());

//WriteLine("Enter operation");
//string operation = ReadLine().ToUpperInvariant();


//var calculator = new Calculator();
//int result = calculator.Calculate(number1, number2, operation);
//DisplayResult(result);


//WriteLine("\nPress enter to exit.");
//ReadLine();


//void DisplayResult(int result)
//{
//    WriteLine($"Result is: {result}");
//}


