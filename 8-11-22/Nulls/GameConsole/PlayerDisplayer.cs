using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("player name is Null,Empty or Whitespace");
              
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            //check for DateofBirth
            if (player.DateOfBirth is null)
            {
                Console.WriteLine("NO Date Of Birth Specified");
            }
               
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }


            //int days=player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1; //Conditional operator

            int days = player.DaysSinceLastLogin ?? -1; //Null Coalescing Operator
            Console.WriteLine($"{days} Days since Last login");

            string nameCoalascing=null; //Null Coalescing assignment Opertor
            nameCoalascing ??= "NULL COALESCING ASSIGNMENT";
            Console.WriteLine($"Name Coalescing:{nameCoalascing}");


            //check for DaysSinceLastLogin
            //if (player.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(player.DaysSinceLastLogin.Value);
                
            //}
            //else
            //{
            //    Console.WriteLine("NO value for DaysSinceLastLogin");
            //}


            //check for IsNew
            if (player.IsNew == null)
            {
                Console.WriteLine("Player new status is unknown");
            }
            else if (player.IsNew == true)
            {
                Console.WriteLine("Player is new to the game");
            }
            else
            {
                Console.WriteLine("Player is Experienced!!");
            }
        }
    }
}
