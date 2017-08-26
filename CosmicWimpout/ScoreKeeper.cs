using System;
using System.Collections.Generic;
using System.Text;

namespace CosmicWimpout
{
    class ScoreKeeper
    {
        //This will need to be greatly expanded for multiple players, but it's a placeholder for now

        public void DisplayScore(int myScore)
        {
            Console.WriteLine();
            Console.WriteLine("Your score is " + myScore);
            Console.WriteLine();
        }
    }
}
