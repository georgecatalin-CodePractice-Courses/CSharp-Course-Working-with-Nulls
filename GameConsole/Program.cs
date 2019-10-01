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
            ////PlayerCharacter player = null;
            //PlayerCharacter player = new PlayerCharacter();
            ////player.DaysSinceLastLogin = 23;

            //int days = player?.DaysSinceLastLogin ?? -1; //use of Null-conditional operator


            ////if (player!=null)
            ////{
            ////   days = player.DaysSinceLastLogin ?? -1;
            ////}
            ////else
            ////{
            ////    days = -1;
            ////}


            //Console.WriteLine(days);



            ////player.Name = "Sara";
            ////player.Name = "";
            ////player.Name = null;
            ////player.DaysSinceLastLogin = 42;

            ////PlayerDisplayer.Write(player);



            //PlayerCharacter[] players = new PlayerCharacter[3]
            //{
            //    new PlayerCharacter {Name="Sara"},
            //    new PlayerCharacter(), //Name=null
            //    null //PlayerCharacter=null
            //};

            PlayerCharacter[] players = null;


            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;

            Console.ReadLine();
        }
    }
}
