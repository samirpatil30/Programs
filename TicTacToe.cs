using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip_Program
{
   public class TicTacToe
    {
        static string[] board;
        static string turn;
        
         public void PlayGame()
        {
            board = new String[9];
            turn = "X";
            String winner = null;
            populateEmptyBoard();

            PrintBoard();

        }
        public void PrintBoard()
        {
            Console.WriteLine(board[0]+"|"+board[0]+ "|"+board[3]);
            Console.WriteLine("______"+"|"+ "______"+"|"+"_______");
            
            Console.WriteLine(         "|"+          "|"          );
            Console.WriteLine(board[4]+"|"+board[5]+ "|"+board[6]);

            Console.WriteLine("______"+"|"+"______"+"|"+ "_______");
            Console.WriteLine(         "|"+          "|"           );
            Console.WriteLine(board[4]+"|"+board[5]+ "|"+ board[6]);
            Console.WriteLine("______"+"|"+"______"+ "|"+"_______");
        }
        void populateEmptyBoard()
        {
            for (int a = 0; a < 9; a++)
            {
                
            }
        }
    }
}
