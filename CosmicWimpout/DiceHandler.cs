using System;
using System.Collections;

namespace CosmicWimpout
{
    class DiceHandler
    {
        public void ShowDiceValues(ArrayList allDice)
        {
            int dieCounter = 0;
            string showDiceOutput = "";
            Console.WriteLine();
            Console.WriteLine("Dice values: (L) = locked die, (U) = unrolled die");

            foreach (Die die in allDice)
            {
                dieCounter++;
                if (dieCounter > 1 && dieCounter <= 5) showDiceOutput += ", ";
                showDiceOutput += "[Die " + dieCounter + "]: ";
                if (String.IsNullOrEmpty(die.GetDieValue())) showDiceOutput += "(U)";
                else showDiceOutput += die.GetDieValue();
                if (die.GetLockedStatus()) showDiceOutput += " (L)";
            }

            Console.WriteLine(showDiceOutput);
            Console.WriteLine();
        }
    }
}
