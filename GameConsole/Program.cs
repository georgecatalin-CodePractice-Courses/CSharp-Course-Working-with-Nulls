using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerCharacter player = new PlayerCharacter();
            player.Name = "Sara";

            PlayerDisplayer.Write(player);


            Console.ReadLine();
        }
    }
}
