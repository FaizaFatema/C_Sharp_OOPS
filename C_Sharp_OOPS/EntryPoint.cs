using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOPS
{
    class EntryPoint
    {
        static void Main(string [] args)
        {
           // Console.WriteLine("Starting programm here");

            Player player = new Player("Player1");
            Console.WriteLine(player.WarriorName());


            Enemy enemy = new Enemy("Enemy");
            Console.WriteLine(enemy.WarriorName2());

        }
    }
}
