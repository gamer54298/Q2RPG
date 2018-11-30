using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleTimmysAdventure
{
    public class Player
    {
        public string Name;
        public static void GameSetUp()
        {
            Console.WriteLine("Welcome to The lost adventure!");
            Console.ReadLine();
            Console.Clear();
            Console.Write("What is your name? ");
            string Name = Console.ReadLine();
            int Points = 0;
            int TotalPoints = 100;
            Console.WriteLine("Alright " + Name + ", You have " + Points + " points.\n\n That is terrible, and you should have " + TotalPoints + " Come back to me when you have that many points.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
