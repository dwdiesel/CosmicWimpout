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
                if (String.IsNullOrEmpty(die.DieValue)) showDiceOutput += "(U)";
                else showDiceOutput += die.DieValue;
                if (die.IsLocked) showDiceOutput += " (L)";
            }

            Console.WriteLine(showDiceOutput);
            Console.WriteLine();
        }

        public void FlashChecker(ArrayList diceToBeChecked)
        {
            
        }

        public void LockDice(ArrayList diceToBeChecked)
        {
            foreach(Die die in diceToBeChecked)
            {

            }
        }
    }
}
