using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTimmysAdventure
{
    class Projectile:Weapon
    {
        public int Capacity;
        public int Ammunition;

        public Projectile(int capacity, int ammunition)
        {
            Capacity = capacity;
            Ammunition = ammunition;
        }
    }
}
