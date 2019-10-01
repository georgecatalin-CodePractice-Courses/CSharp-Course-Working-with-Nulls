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

        public int Health { get; set; } = 100;

        private readonly ISpecialDefence _specialDefence;


        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            this._specialDefence = specialDefence;
        }

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if (_specialDefence != null)
            //{
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}


            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health was reduced by {totalDamageTaken} to the value of {Health}");

        }

    }
}
