using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console_practice_Null_Object_pattern
{
    public abstract class Shield
    {
        public abstract int DamageReduction();

        public class NoShield:Shield
        {
            public override int DamageReduction() { return 0; }
        }
    }
}
