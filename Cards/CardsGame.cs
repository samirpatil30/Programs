// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CardsGame.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Samir Patil"/>
// -------------------------------------------------------------------------------------------------------------------
namespace ObjectOriented.Cards
{
    using System;

    /// <summary>
    /// Cards Game
    /// </summary>
    public class CardsGame
   {      
      public void GameOfCards()
      {
            ///Crete the instance of Utility
            Utility utility = new Utility();
           // AbstactCard abstactCard = utility;
           // abstactCard.showList();

            char character = ' ';
            do
            {
                Console.WriteLine("1)Display players cards \n 2) Display queue");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        string[] result = utility.CardsShuffleing();
                        foreach (string temp in result)
                        {
                            utility.InsertIntoList(temp);
                        }
                        break;

                    case 2:
                        Console.WriteLine("*********************************");
                        Console.WriteLine("This Is Queue using linked list");
                        utility.showList();
                        Console.WriteLine();
                        break;
                }

                Console.WriteLine("Continoue y or n");
                character = Convert.ToChar(Console.ReadLine());
            } while (character == 'y');     
      }
   }
}
