using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Project
{
    public static class Int32Extension
    {
        public static long Factorial(this Int32 number)
        {
            if (number == 1)
                return 1;
            else if (number == 2)
                return 2;
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public static bool IsPrime(this Int32 number)
        {
            for(int divisor = 2; divisor < number; divisor++)
            {
                if (number % divisor == 0) { return false; }
            }
            return true;
        }




    }
}
