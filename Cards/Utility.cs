
using System;
using System.Collections.Generic;
using System.Text;
using ObjectOriented.Cards;
namespace ObjectOriented.Cards
{
   public class Utility 
    {

        public string[] CardsShuffleing()
        {
            Model model = new Model();
           
            int totalCards = model.suit.Length * model.rank.Length;
            string[,] deck = new string[4, 13];
            int lengthOfSuits = model.suit.Length;
            int lengthOfRank = model.rank.Length;
           
            Console.WriteLine("How many cards you want to distribute");           
            model.CardsToDistribute = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How Many player want to play ");
            model.NumberOfUser = Convert.ToInt32(Console.ReadLine());

            string[] arrayOfPlayer1 = new string[model.CardsToDistribute];
            string temp = string.Empty;

            //// iterate for loop to initilize a deck
            for (int i = 0; i < lengthOfSuits; i++)
            {
                for (int j = 0; j <= lengthOfRank-1; j++)
                {
                    temp = model.rank[j] + " Of " + model.suit[i];
                    deck[i, j] = temp;                  
                }
            }

            int column = deck.GetUpperBound(1) + 1;
            //// Create instance of Random 
            Random random = new Random();
            ////iterate for loop for shuffleing cards
            for (int i = 0; i < totalCards - 1; i++)
            {
                int randomNumber = random.Next(i, totalCards);
                int rowI = i / column;
                int columnI = i % column;

                int rowJ = randomNumber / column;
                int columnJ = randomNumber % column;

                string tempOne = deck[rowI, columnI];
                deck[rowI, columnI] = deck[rowJ, columnJ];
                deck[rowJ, columnJ] = tempOne;
            }

            int count = 1;
            string tempTwo = string.Empty;
           
            int tempInteger = 0;
                ////iterate the for loop for distribute the cards
            for (int i = 0; i < model.NumberOfUser; i++)
            {
               Console.WriteLine("Player" + count + " Got");
               Console.WriteLine("***************************");
               for (int j = 0; j < model.CardsToDistribute; j++)
               {
                    Console.WriteLine(deck[i, j]);
                    tempTwo = deck[i, j];
                    if(i == 0)
                    {
                        arrayOfPlayer1[tempInteger] = tempTwo;
                        tempInteger++;
                    }        
               }

               count++;
               Console.WriteLine("****************************");
            }

            ////Used the Array function to sort the array
            Array.Sort(arrayOfPlayer1);                
            return arrayOfPlayer1;
        }

        /// <summary>
        /// Insert Into List
        /// </summary>
        Node Rear, Front;
        public  void InsertIntoList(string data)
        {    
            Node Newnode = new Node();
            Newnode.data = data;
            Newnode.next = null;

            if (Front == null)
            {
                Front = Rear = Newnode;
            }
            else
            {
                Rear.next = Newnode;
                Rear = Newnode;
            }
            showList();
        }

        public  void showList()
        {
            Node node = Front;
            while (node.next != null)
            {
                Console.Write(node.data + " ==> ");
                node = node.next;
            }

            Console.WriteLine(node.data);
        }
   }
}
