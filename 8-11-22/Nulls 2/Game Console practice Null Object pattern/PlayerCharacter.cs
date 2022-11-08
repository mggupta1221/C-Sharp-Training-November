using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console_practice_Null_Object_pattern
{
    public class PlayerCharacter
    {

        private Shield _typeOfShield;
        public string? Name { get; set;}
        public int Health { get;} = 100;

        public PlayerCharacter(Shield typeOfShield)
        {
            _typeOfShield=typeOfShield;
        }

        public void Hit(int damage)
        {
            int defencePower = _typeOfShield.DamageReduction();

            int totalDefenceReduction = Math.Abs(defencePower - damage);

            int newHealth=Health-totalDefenceReduction;

            Console.WriteLine($"{Name}'s Protection reduced by {totalDefenceReduction} Remaining Health is {newHealth}");

        }
    }
}
