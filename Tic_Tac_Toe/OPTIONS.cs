using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class OPTIONS
    {
        
        internal static char PrintOptions()
        {
            char option;
            do
            {
                Console.WriteLine("Welcome to Tic Tac Toe");
                Console.WriteLine("Player 1 is X and Player 2 is O");
                Console.WriteLine("Press P to play with another player or Q to quit");
                Console.WriteLine("Press R to play with the random computer");
                Console.WriteLine("Press B to play with the computer");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.P)
                {
                    Console.WriteLine("You have chosen to play with another player");
                    option = 'P';
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("You have chosen to quit");
                    option = 'Q';
                }
                
                else if (key.Key == ConsoleKey.R)
                {
                    Console.WriteLine("You have chosen to play with the random computer");
                    option = 'R';
                }
                else if (key.Key == ConsoleKey.B)
                {
                    Console.WriteLine("You have chosen to play with the computer");
                    option = 'B';
                }
                else
                {
                    Console.WriteLine("You have chosen an invalid option");
                    continue;
                }
                return option;
            }
            while (true);

        }
    }
}
