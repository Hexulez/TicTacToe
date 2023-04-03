using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class CheckWinning
    {
        internal static int Winning(char[] board)
        {

            #region Horzontal Winning Condition
            if (board[1] == board[2] && board[2] == board[3])
            {
                return 1;
            }
            else if (board[4] == board[5] && board[5] == board[6])
            {
                return 1;
            }
            else if (board[7] == board[8] && board[8] == board[9])
            {
                return 1;
            }
            #endregion
            #region Vertical Winning Condition
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            else if (board[3] == board[6] && board[6] == board[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (board[1] == board[5] && board[5] == board[9])
            {
                return 1;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' &&
                     board[4] != '4' && board[5] != '5' && board[6] != '6' &&
                     board[7] != '7' && board[8] != '8' && board[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
            

        }
    }
}
