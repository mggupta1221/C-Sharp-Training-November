using System;

namespace GameConsole
{
    class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public string Name { get; set; }
        public int Health { get; private set; } = 100;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public void Hit(int damage)
        {
            int damageReduction = _specialDefence.CalculateDamageReduction();

            int totalDamageTaken = Math.Abs(damage - damageReduction);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }
    }
}