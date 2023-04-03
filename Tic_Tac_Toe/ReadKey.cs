using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class ReadKey
    {
        internal static int ReadNumbers()
        {
            while (true)
            {
                int option;
                Console.WriteLine("Give number");
                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("You have chosen 1");
                    option = 1;
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("You have chosen 2");
                    option = 2;
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("You have chosen 3");
                    option = 3;
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("You have chosen 4");
                    option = 4;
                }
                else if (key.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("You have chosen 5");
                    option = 5;
                }
                else if (key.Key == ConsoleKey.D6)
                {
                    Console.WriteLine("You have chosen 6");
                    option = 6;
                }
                else if (key.Key == ConsoleKey.D7)
                {
                    Console.WriteLine("You have chosen 7");
                    option = 7;
                }
                else if (key.Key == ConsoleKey.D8)
                {
                    Console.WriteLine("You have chosen 8");
                    option = 8;
                }
                else if (key.Key == ConsoleKey.D9)
                {
                    Console.WriteLine("You have chosen 9");
                    option = 9;
                }
                else
                {
                    Console.WriteLine("You have chosen an invalid option");
                    continue;
                }
                return option;
            }
        }
        
        
        internal static int YesNo()
        {
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                return 0;
            }
            else if (key.Key == ConsoleKey.N)
            {
                return 1;
            }
            else
            {
                return YesNo();
            }
        }
        
    }
}
