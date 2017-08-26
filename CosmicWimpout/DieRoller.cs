using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    class DieRoller
    {
        public void RollDice(ArrayList diceToRoll)
        {
            int dieRoll = -1;
            Random rndSeed = new Random();
            foreach (Die die in diceToRoll)
            {
                dieRoll = rndSeed.Next(0, 5);
                die.SetDieValue(dieRoll);
            }
        }
    }
}
