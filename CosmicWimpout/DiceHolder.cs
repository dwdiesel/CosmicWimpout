using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CosmicWimpout
{
    class DiceHolder
    {
        private int numberOfTwos, numberOfThrees, numberOfFours, numberOfFives, numberOfSixes, numberOfTens, numberOfFlamingSuns;
        ArrayList diceInHolder;

        public DiceHolder()
        {
            diceInHolder = new ArrayList();
        }

        public void AddDieToHolder(Die dieToAdd)
        {
            diceInHolder.Add(dieToAdd);
            switch(dieToAdd.DieValue)
            {
                case "2":
                    NumberOfTwos++;
                    break;
                case "3":
                    NumberOfThrees++;
                    break;
                case "4":
                    NumberOfFours++;
                    break;
                case "5":
                    NumberOfFives++;
                    break;
                case "6":
                    NumberOfSixes++;
                    break;
                case "FlamingSun":
                    NumberOfFlamingSuns++;
                    break;
            }
        }

        public void RemoveDieFromHolder(Die dieToRemove)
        {
            if (diceInHolder.Contains(dieToRemove))
            {
                diceInHolder.Remove(dieToRemove);
                switch (dieToRemove.DieValue)
                {
                    case "2":
                        NumberOfTwos--;
                        break;
                    case "3":
                        NumberOfThrees--;
                        break;
                    case "4":
                        NumberOfFours--;
                        break;
                    case "5":
                        NumberOfFives--;
                        break;
                    case "6":
                        NumberOfSixes--;
                        break;
                    case "FlamingSun":
                        NumberOfFlamingSuns--;
                        break;
                }
            }
        }

        public int NumberOfTwos
        {
            get { return this.numberOfTwos; }
            set { this.numberOfTwos = value; }
        }

        public int NumberOfThrees
        {
            get { return this.numberOfThrees; }
            set { this.numberOfThrees = value; }
        }

        public int NumberOfFours
        {
            get { return this.numberOfFours; }
            set { this.numberOfFours = value; }
        }

        public int NumberOfFives
        {
            get { return this.numberOfFives; }
            set { this.numberOfFives = value; }
        }

        public int NumberOfSixes
        {
            get { return this.numberOfSixes; }
            set { this.numberOfSixes = value; }
        }

        public int NumberOfTens
        {
            get { return this.numberOfTens; }
            set { this.numberOfTens = value; }
        }

        public int NumberOfFlamingSuns
        {
            get { return this.numberOfFlamingSuns; }
            set { this.numberOfFlamingSuns = value; }
        }
    }
}
