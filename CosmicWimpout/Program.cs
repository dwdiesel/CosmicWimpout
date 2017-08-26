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

            while (!quitGame)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(S)how current dice, (V)iew score, (L#)ock die #, (R)oll unlocked dice, (Q)uit");
                userInput = Console.ReadLine();
                switch (userInput.ToUpper())
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
                        myDieRoller.RollDice(diceToRoll);
                        myDiceHandler.ShowDiceValues(allDice);
                        diceToRoll.Clear();
                        break;
                }
            }
        }
    }
}
