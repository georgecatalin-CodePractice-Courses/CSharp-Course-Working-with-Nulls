using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        //public Nullable<int> DaysSinceLastLogin { get; set; }

        public int? DaysSinceLastLogin { get; set; } //C# shorthand for representation of nullable value types

        //public Nullable<DateTime> DateOfBirth { get; set; }

        public DateTime? DateOfBirth { get; set; } //C# shorthand representation of nullable value types

        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
            //this.DaysSinceLastLogin = -1;  //magic number
            //this.DateOfBirth = DateTime.MinValue; //magic number

            this.DaysSinceLastLogin = null;
            this.DateOfBirth = null;
        }

    }
}
