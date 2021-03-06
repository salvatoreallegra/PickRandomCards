using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    public class CardPicker
    {
        static Random random = new Random();
        public  string[] pickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = randomValue() + " of " + randomSuit();
            }
            return pickedCards;
        }

        public string randomSuit()
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
            if (randomValue == 13)
            {
                return "K";
            }
            if (randomValue == 12)
            {
                return "Q";
            }
            if (randomValue == 11)
            {
                return "J";
            }
            return randomValue.ToString();
        }
        
    }
}
