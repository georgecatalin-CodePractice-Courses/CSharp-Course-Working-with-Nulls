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
            if (string.IsNullOrWhiteSpace(playerCharacter.Name))
            {
                Console.WriteLine("Player name is null or all white space");
            }
            else
            {
                Console.WriteLine(playerCharacter.Name);
            }

            //int days = playerCharacter.DaysSinceLastLogin.GetValueOrDefault(-1);

             int days =     playerCharacter.DaysSinceLastLogin ?? -1;  //using the Null-coalescing operator like this

            //int days =     playerCharacter.DaysSinceLastLogin.HasValue ? playerCharacter.DaysSinceLastLogin.Value : -1;  //using the conditional operator like this

            Console.WriteLine($"{days} days since the last login");

            //if (playerCharacter.DaysSinceLastLogin.HasValue)
            //{
            //    Console.WriteLine(playerCharacter.DaysSinceLastLogin);
                
            //}
            //else
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //    Console.WriteLine(playerCharacter.DaysSinceLastLogin.GetValueOrDefault(10));
            //}

            if (playerCharacter.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if (playerCharacter.IsNoob == null)
            {
                Console.WriteLine("Newbie status is unknown for this player");
            }
            else if (playerCharacter.IsNoob == true)
            {
                Console.WriteLine("Affirmative, this player is a newbie");
            }
            else
            {
                Console.WriteLine("No, this player is not a newbie");
            }


        }
    }
}
