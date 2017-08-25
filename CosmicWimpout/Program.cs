using System;
using System.Collections;

namespace CosmicWimpout
{
    class Program
    {
        static void Main(string[] args)
        {
            WhiteDie firstWhiteDie = new WhiteDie();
            WhiteDie secondWhiteDie = new WhiteDie();
            WhiteDie thirdWhiteDie = new WhiteDie();
            WhiteDie fourthWhiteDie = new WhiteDie();
            BlackDie blackDie = new BlackDie();
            DieRoller myDieRoller = new DieRoller();
            string rollOutput = "";

            ArrayList diceToRoll = new ArrayList();
            diceToRoll.Add(firstWhiteDie);
            diceToRoll.Add(secondWhiteDie);
            diceToRoll.Add(thirdWhiteDie);
            diceToRoll.Add(fourthWhiteDie);
            diceToRoll.Add(blackDie);

            myDieRoller.RollDice(diceToRoll);

            foreach (Die die in diceToRoll)
            {
                rollOutput += die.GetDieValue() + " ";
            }

            Console.WriteLine("You rolled " + diceToRoll.Count + " dice: " + rollOutput);
        }
    }

    abstract class Die
    {
        protected ArrayList sides = new ArrayList();
        protected string dieValue = "";
        protected string[] dieSides = new string[NUMBER_OF_SIDES];
        protected const int NUMBER_OF_SIDES = 6;

        public void SetDieValue(int valueToSet)
        {
            if (valueToSet >= 0 && valueToSet < NUMBER_OF_SIDES)
            {
                this.dieValue = this.dieSides[valueToSet];
            }
        }

        public string GetDieValue()
        {
            return this.dieValue;
        }
    }

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
        }
    }

    class BlackDie : Die
    {
        public BlackDie()
        {
            string[] sidesToLoad = new string[6] { "2", "4", "5", "6", "10", "S" };
            int loadCounter = 0;
            foreach (string sideToLoad in sidesToLoad)
            {
                this.dieSides[loadCounter] = sideToLoad;
                loadCounter++;
            }
        }
    }

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
