﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class PlayerVsPlayer
    {
         
        internal static void Play()
        {
            int flag = 0;
            int playernmb = 1;
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int choice;
            char mark = 'X';
            Drawboard.Board(board, playernmb, mark);
            do
            {
                mark = (playernmb == 1) ? 'X' : 'O';
                
                //ask player where to want put mark
                choice = ReadKey.ReadNumbers();
                //clone board
                char[] prevBoard = (char[])board.Clone();
                //update board
                board = BoardUpdate.UpdateBoard(board, choice, playernmb);
                //draw board
                Drawboard.Board(board, playernmb, mark);
                //check winning
                flag = CheckWinning.Winning(board);
                if (flag == 1)
                {
                    Console.WriteLine("Player " + playernmb + " Win!");
                    Console.WriteLine("play again? (Y/N)");
                    flag = ReadKey.YesNo();
                    board = ResetBoard.Reset();
                    //draw board
                    Drawboard.Board(board, playernmb, mark);

                }
                else if (flag == -1)
                {
                    Console.WriteLine("It was draw!");
                    Console.WriteLine("play again?");
                    flag = ReadKey.YesNo();
                    board = ResetBoard.Reset();
                    //draw board
                    Drawboard.Board(board, playernmb, mark);
                }

                playernmb = playernmb == 1 ? 2 : 1;


                



            }
            while (flag == 0);
        }
    }
}
