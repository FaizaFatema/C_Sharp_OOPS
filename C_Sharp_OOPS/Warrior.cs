using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOPS
{
    class Warrior
    {
        protected int health=100;
        protected string name;

        protected Weapon weapon;
        protected Armor armor;

        protected bool isAlive;

        public string WarriorName()
        {
            return name ;
        }
        public string WarriorName2()
        {
            return name;
        }
    }
}
