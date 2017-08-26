using System;
using System.Collections.Generic;
using System.Text;

namespace CosmicWimpout
{
    class WhiteDie : Die
    {
        public WhiteDie()
        {
            string[] sidesToLoad = new string[6] { "2", "3", "4", "5", "6", "10" };
            int loadCounter = 0;
            foreach (string sideToLoad in sidesToLoad)
            {
                this.dieSides[loadCounter] = sideToLoad;
                loadCounter++;
            }
            // Initialize die as unlocked
            this.IsLocked = false;
        }
    }
}