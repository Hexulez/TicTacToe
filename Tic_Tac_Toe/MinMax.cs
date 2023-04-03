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
            int bestMove;
            int startScore = 0;
            //allMoves list starting value
            List<int> allMoves = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {

                    int score;
                    char[] nextboard = (char[])board.Clone();
                    nextboard[i] = isMax ? '0' : 'X';

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
                        score = Minmax(nextboard, depth + 1, !isMax);
                        
                    }

                    if (!isMax && maxScore <= score)
                    {
                        if (allMoves.Count > 0 && startScore != score)
                        {
                            allMoves.Clear();
                            startScore = score;
                        }
                        maxScore = score;
                        allMoves.Add(i);
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
