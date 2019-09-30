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


            

            //if (playerCharacter.DaysSinceLastLogin== -1)
            //{
            //    Console.WriteLine("No value for DaysSinceLastLogin" );
            //}
            //else
            //{
            //    Console.WriteLine(playerCharacter.DaysSinceLastLogin);
            //}

            //if (playerCharacter.DateOfBirth==DateTime.MinValue)
            //{
            //    Console.WriteLine("No date of birth specified");
            //}
            //else
            //{
            //    Console.WriteLine(playerCharacter.DateOfBirth);
            //}

            if (playerCharacter.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(playerCharacter.DaysSinceLastLogin);
            }

            if (playerCharacter.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(playerCharacter.DateOfBirth);
            }

            if (playerCharacter.IsNoob== null)
            {
                Console.WriteLine("Newbie status is unknown for this player") ;
            }
            else if (playerCharacter.IsNoob==true)
            {
                Console.WriteLine("Affirmative, this player is a newbie") ;
            }
            else
            {
                Console.WriteLine("No, this player is not a newbie");
            }


        }
    }
}
