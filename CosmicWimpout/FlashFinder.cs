using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    public static class FlashFinder
    {
        public static FlashBus FindFlash(ArrayList diceToBeChecked)
        {
            FlashBus listOfFlashes = new FlashBus();
            ArrayList diceInAFlash = new ArrayList(); // This ArrayList will be populated with all dice that are confirmed as part of the flash
            if (diceToBeChecked.Count < 3) return listOfFlashes; // You can't have a flash with fewer than three dice, stop wasting my time, kid
            Boolean flamingSunPresent = false; // This bool will save us some time differentiating a flash from a freight train
            

            // Here we are going to load up an ArrayList called diceInAFlash with dice that match each other in value or are a Flaming Sun
            for (int outerLoopCounter = 0; outerLoopCounter < diceToBeChecked.Count; outerLoopCounter++)
            {
                // If the die currently being checked (indicated by the outerLoopCounter) is a Flaming Sun, there is no point to loading it in
                // the diceInAFlash ArrayList because nothing will match it, and it will get loaded as part of the next die's check anyway
                if ((diceToBeChecked[outerLoopCounter] as Die).DieValue == "Flaming Sun") continue;
                // Assume the die currently being checked (indicated by the outerLoopCounter) is part of a flash and add it to the diceInAFlash ArrayList
                diceInAFlash.Add(diceToBeChecked[outerLoopCounter]);
                for (int innerLoopCounter = 0; innerLoopCounter < diceToBeChecked.Count; innerLoopCounter++)
                {
                    // If the two counters are equal, you're comparing the die to itself, move along, nothing to see here
                    if (outerLoopCounter == innerLoopCounter) continue;
                    // If this die (indicated by innerLoopCounter) has the same value as the die being checked (indicated by the outerLoopCounter)
                    // or is a Flaming Sun, add it to the diceInAFlash ArrayList because it's part of the potential flash
                    if ((diceToBeChecked[innerLoopCounter] as Die).DieValue == (diceToBeChecked[outerLoopCounter] as Die).DieValue
                        || (diceToBeChecked[innerLoopCounter] as Die).DieValue == "Flaming Sun")
                    {
                        diceInAFlash.Add(diceToBeChecked[innerLoopCounter]);
                    }
                }
                // Now we are only interested in the dice in diceInAFlash if there are three or more of them. If there are five, we're only interested
                // if one of them is a Flaming Sun, otherwise you have a freight train, not a flash.
                if ((diceInAFlash.Count >= 3 && diceInAFlash.Count < 5) || (diceInAFlash.Count == 5 && !flamingSunPresent)) listOfFlashes.ListOfFlashes = diceInAFlash;
                // Resent variables before checking the next die
                diceInAFlash.Clear();
                flamingSunPresent = false;
            }

            return listOfFlashes;
        }
    }
}
