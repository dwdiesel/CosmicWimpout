using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    public static class FlashFinder
    {
        public static Boolean FindFlash(ArrayList diceToBeChecked)
        {
            ArrayList diceInAFlash;
            if (diceToBeChecked.Count < 3) return false; // You can't have a flash with fewer than three dice

            for (int outerLoopCounter = 0; outerLoopCounter < diceToBeChecked.Count; outerLoopCounter++)
            {
                for (int innerLoopCounter = 0; innerLoopCounter < diceToBeChecked.Count; innerLoopCounter++)
                {

                }
            }

            return true;
        }
    }
}
