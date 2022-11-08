using static Game_Console_practice_Null_Object_pattern.Shield;

namespace Game_Console_practice_Null_Object_pattern
{
    public class Program
    {
        public static void Main()
        {

            PlayerCharacter mukesh =new PlayerCharacter(new DiamondShield())
                {
                    Name = "Mukesh"
                };

            PlayerCharacter nikhil = new PlayerCharacter(new IronShield())
                {
                    Name = "Nikhil"
                };

            PlayerCharacter mahesh = new PlayerCharacter(new NoShield())
            {
                Name = "Mahesh"
            };
            Console.WriteLine("Attack To reduce protection level by 10");
            mukesh.Hit(10);
            nikhil.Hit(10);
            mahesh.Hit(10);
        }
    }
}