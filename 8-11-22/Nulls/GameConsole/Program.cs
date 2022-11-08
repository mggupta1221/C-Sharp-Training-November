using System;

namespace GameConsole
{
    class Program
    {
        public static void Main()
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter{Name="Sarah" },
                new PlayerCharacter(),
                null
            };

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine();

        }


















        //public static void Main()
        //{
        //    PlayerCharacter player=new PlayerCharacter();
        //    player.Name = "Mukesh";
        //    player.DateOfBirth = new DateTime(1999, 10, 15);
        //    player.IsNew = null;
        //    //player.DaysSinceLastLogin = 33;

        //    PlayerDisplayer.Write(player);
        //}


        //public static void Main()
        //{
        //    PlayerCharacter player = new PlayerCharacter();

        //    int days = player?.DaysSinceLastLogin ?? -1;

        //    Console.WriteLine(days);

        //}
    }
}
