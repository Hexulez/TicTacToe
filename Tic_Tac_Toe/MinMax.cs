using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class MinMax
    {
        internal int Minmax(char[] board, int depth, bool isMax)
        {

            int maxScore =int.MinValue;
            int minScore = int.MaxValue;
            int bestMove = -1;
            int startScore = 0;
            
            //check all placement
            for (int i = 1; i < 10; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {

                    int score;
                    //clone orginal gameboard
                    char[] nextboard = (char[])board.Clone();
                    //check is it AI or player turn now
                    nextboard[i] = isMax ? 'O' : 'X';

                    //check winning
                    int winning = CheckWinning.Winning(nextboard);

                    if (winning == 1)
                    {
                        if (!isMax)
                        {
                            score = depth - 10;
                        }
                        else
                        {
                            score = 10 - depth;
                        }
                    }

                    else if (winning == -1)
                    {
                        score = 0;
                    }
                    else
                    {
                        //if game continue after next move call same minmax method again to check next move.
                        score = Minmax(nextboard, depth + 1, !isMax);
                        
                    }

                    //set best move depending is it player or AI turn
                    if (!isMax && minScore > score)
                    {
                        minScore = score;
                        bestMove = i;
                        
                    }
                    else if (maxScore > score)
                    {
                        maxScore = score;
                        bestMove = i;
                    }

                    
                }
            }
            
            return bestMove;
        }
    }
}
