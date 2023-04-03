using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class BoardUpdate
    {
        internal static char[] UpdateBoard(char[] board, int choice, int playernmb)
        {
            if (playernmb == 1 && board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = 'X';
            }
            else if (playernmb == 2 && board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = 'O';
            }
            else
            {
                Console.WriteLine("Invalid move");
                choice = ReadKey.ReadNumbers();
                board = UpdateBoard(board, choice, playernmb);
            }
            return board;
        }
    }
}
