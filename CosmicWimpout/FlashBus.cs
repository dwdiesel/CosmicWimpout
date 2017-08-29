using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    public class FlashBus
    {
        private ArrayList listOfFlashes;

        public FlashBus()
        {
            listOfFlashes = new ArrayList();
        }

        public ArrayList ListOfFlashes
        {
            get { return listOfFlashes; }

            // The whole idea behind this set property is to guard against saving the same value of flash twice.
            // This should make the job of FlashFinder easier because it won't have to worry about if it finds
            // more than one flash where only one flash exists. For example, [2][2][2][2][FlamingSun]. FlashFinder
            // will check the first [2] and find a flash. It will check the second [2] and find a flash again, etc.
            //
            // Also, this set property will only work if an ArrayList is sent. This effectively makes listOfFlashes
            // a matrix.
            set
            {
                string existingFlashValue = ""; // To record the value of a flash already present in the FlashBus
                string incomingFlashValue = ""; // To record the value of an incoming flash
                if (this.listOfFlashes.Count == 0 && value is ArrayList)
                {
                    listOfFlashes.Add(value);
                }
                // Assumption: There can never be more than two flash candidates
                else if (this.listOfFlashes.Count == 1 && value is ArrayList)
                {
                    // Assumption: Except for a Flaming Sun, there will never be more than one die value
                    // in a flash
                    foreach (Die die in (listOfFlashes[0] as ArrayList))
                    {
                        if ((die as Die).DieValue != "Flaming Sun") existingFlashValue = (die as Die).DieValue;
                    }
                    foreach (Die die in (value as ArrayList))
                    {
                        if ((die as Die).DieValue != "Flaming Sun") incomingFlashValue = (die as Die).DieValue;
                    }
                    if (existingFlashValue != incomingFlashValue) listOfFlashes.Add(value);
                }
            }
        }

    }
}
