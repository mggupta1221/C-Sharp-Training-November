using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
           

            string nonNullOperation=operation?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("............................Logging......................");
                    //Log.Error(ex);
                    //throw; //rethrowing exception
                    //throw new ArithmeticException("An Error occured During Calculation.", ex);

                    throw new CalculationException (ex);
                }


                
            }
            else
            {
                throw new CalculationOperationNotSupportedException(nonNullOperation);
                //throw new ArgumentOutOfRangeException(nameof(nonNullOperation),$"The Mathematical Operation {nonNullOperation} Is not Supported");
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}

