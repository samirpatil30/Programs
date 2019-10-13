// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Model.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Cards
{
    /// <summary>
    /// Model
    /// </summary>
    public class Model
    {
        /// <summary>
        /// 
        /// </summary>
        private int numberOfUser;
        /// <summary>
        /// 
        /// </summary>
        private int cardsToDistribute;
        /// <summary>
        /// 
        /// </summary>
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public string[] suit = { "Clubs", "Diamonds", "Hearts", "Spades" };

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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
