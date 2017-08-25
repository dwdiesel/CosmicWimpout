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
            ScoreKeeper myScoreKeeper = new ScoreKeeper();
            DiceHandler myDiceHandler = new DiceHandler();
            string rollOutput = "";
            string userInput = "";
            Boolean quitGame = false;
            int myScore = 0;
            ArrayList diceToRoll = new ArrayList();
            ArrayList allDice = new ArrayList();

            //Initially add all dice into diceToRoll and allDice ArrayLists
            diceToRoll.Add(firstWhiteDie);
            allDice.Add(firstWhiteDie);
            diceToRoll.Add(secondWhiteDie);
            allDice.Add(secondWhiteDie);
            diceToRoll.Add(thirdWhiteDie);
            allDice.Add(thirdWhiteDie);
            diceToRoll.Add(fourthWhiteDie);
            allDice.Add(fourthWhiteDie);
            diceToRoll.Add(blackDie);
            allDice.Add(blackDie);

            Console.WriteLine("Welcome to Cosmic Wimpout!");
            Console.WriteLine();

            while(!quitGame)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(S)how current dice, (V)iew score, (L#)ock die #, (R)oll unlocked dice, (Q)uit");
                userInput = Console.ReadLine();
                switch(userInput.ToUpper())
                {

                    case "Q":
                        quitGame = true;
                        break;
                    case "V":
                        myScoreKeeper.DisplayScore(myScore);
                        break;
                    case "S":
                        myDiceHandler.ShowDiceValues(allDice);
                        break;
                    case "L1":
                    case "L2":
                    case "L3":
                    case "L4":
                    case "L5":
                        break;
                    case "R":
                        break;
                }
            }

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
        protected Boolean isLocked;

        public void SetDieValue(int valueToSet)
        {
            if (valueToSet >= 0 && valueToSet < NUMBER_OF_SIDES)
            {
                this.dieValue = this.dieSides[valueToSet];
            }
            isLocked = false;
        }

        public string GetDieValue()
        {
            return this.dieValue;
        }

        public Boolean GetLockedStatus()
        {
            return this.isLocked;
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

    class ScoreKeeper
    {
        //This will need to be greatly expanded for multiple players, but it's a placeholder for now

        public void DisplayScore(int myScore)
        {
            Console.WriteLine("Your score is " + myScore);
        }
    }

    class DiceHandler
    {
        public void ShowDiceValues(ArrayList allDice)
        {
            int dieCounter = 0;
            string showDiceOutput = "";
            Console.WriteLine();
            Console.WriteLine("Dice values: (L) = locked die, (U) = unrolled die");
            
            foreach(Die die in allDice)
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
