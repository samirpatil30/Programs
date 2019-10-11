using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented.Cards
{
    public class Model
    {
        private int numberOfUser;
        private int cardsToDistribute;
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public int NumberOfUser
        {
            get
            {
                return numberOfUser;
            }
            set
            {
                this.numberOfUser = value;
            }
        }

        public int CardsToDistribute
        {
            get
            {
                return cardsToDistribute;
            }
            set
            {
                this.cardsToDistribute = value;
            }
        }

    }  
    
}
