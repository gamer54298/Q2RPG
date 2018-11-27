using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTimmysAdventure
{
    public class Weapon
    {
        public int Damage;
        public int Worth;
        public bool IsMagical;
        public bool Modifier;

        public Weapon(int damage, int worth, bool isMagical, bool modifier)
        {
            Damage = damage;
            IsMagical = isMagical;
            Modifier = modifier;
            Worth = worth;
        }

        public Weapon()
        {

        }
    } 

}
