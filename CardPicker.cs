using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        public static string[] pickSomeCards(int numOfCards)
        {
            string[] pickedCards = new string[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                pickedCards[i] = randomValue() + " of " + randomSuit();
            }
            return pickedCards;
        }

        public static string randomValue()
        {
            return "";
        }

        public static string randomSuit()
        {
            return "";
        }
        
    }
}
