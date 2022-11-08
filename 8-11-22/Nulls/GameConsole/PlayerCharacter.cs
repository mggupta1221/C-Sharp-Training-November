using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class PlayerCharacter
    {
        public string? Name { get; set; }    
        public Nullable <int> DaysSinceLastLogin { get; set; }   //==public int? DaysSinceLastlogin{get;set;}
        public Nullable<DateTime>  DateOfBirth { get; set; }     //or public DateTime?  DateOfBirth { get; set; }

        public bool? IsNew { get; set; }


        public PlayerCharacter()
        {
            DaysSinceLastLogin = null;
            DateOfBirth = null;
        }

    }
}
