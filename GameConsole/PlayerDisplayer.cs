using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter playerCharacter)
        {
            Console.WriteLine(playerCharacter.Name);

            if (playerCharacter.DaysSinceLastLogin== -1)
            {
                Console.WriteLine("No value for DaysSinceLastLogin" );
            }
            else
            {
                Console.WriteLine(playerCharacter.DaysSinceLastLogin);
            }

            if (playerCharacter.DateOfBirth==DateTime.MinValue)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }
        }
    }
}
