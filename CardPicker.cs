using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] pickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = randomValue() + " of " + randomSuit();
            }
            return pickedCards;
        }

        public static string randomSuit()
        {
            int randomIntegerValue = random.Next(1, 5);  //generate a random integer value from 1 to 4
            if (randomIntegerValue == 1)
            {
                return "Spades";
            }
            if (randomIntegerValue == 2)
            {
                return "Hearts";
            }
            if (randomIntegerValue == 3)
            {
                return "Clubs";
            }
            return "Diamonds";
        }

        public static string randomValue()
        {
           int randomValue = random.Next(1, 14);
            if(randomValue == 1)
            {
                return "A";
            }
            if (randomValue == 2)
            {
                return "K";
            }
            if (randomValue == 3)
            {
                return "Q";
            }
            if (randomValue == 4)
            {
                return "J";
            }
            return randomValue.ToString();
        }
        
    }
}
