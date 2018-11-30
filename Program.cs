using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTimmysAdventure
{
    class Program
    {
        public int Points;
        public int TotalPoints; 

        static void Main(string[] args)
        {

            Player.GameSetUp();
            Game.MainGame();
            

        }
    }
}
