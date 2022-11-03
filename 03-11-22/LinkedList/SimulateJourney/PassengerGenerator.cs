using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateJourney
{
    public class PassengerGenerator
    {
        private static int _count;

        public static Passenger CreatePassenger()
        {
        
            Random randomNumberGenerator=new Random();
            int randomNumber= randomNumberGenerator.Next(1,3);
            string Destination = "";

            if (randomNumber % 2 == 0)
                Destination = "Lancaster";
            else
                Destination = "Pune";

            return new Passenger($"Person {++ _count}", Destination);
        }
    }
}
