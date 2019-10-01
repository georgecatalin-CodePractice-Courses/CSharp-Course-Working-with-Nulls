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
            PlayerCharacter george = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "George"
            };

            PlayerCharacter alex = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Alex"
            };

            PlayerCharacter cornel = new PlayerCharacter(new NullDefence())
            {
                Name = "Cornel"
            };

            george.Hit(10);
            alex.Hit(10);
            cornel.Hit(10);

            Console.ReadLine();
        }
    }
}
