using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOPS
{
    class Player:Warrior
    {
        public Player(string name)
        {
            this.name = name;
            isAlive = true;
            health = 10;

            armor = new Armor(10);
            weapon = new Weapon(10);



        }
    }
}
