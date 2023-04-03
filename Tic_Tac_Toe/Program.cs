namespace Tic_Tac_Toe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                char choice = OPTIONS.PrintOptions();
                if (choice == 'Q')
                {
                    break;
                }
                else if (choice == 'P')
                {
                    PlayerVsPlayer.Play();
                }
                
                else if (choice == 'R')
                {
                    PlayerVsRandomComputer.Play();
                }
                
                else if (choice == 'B')
                {
                    PlayerVsComputer.Play();
                }
                

            }

        }

    }    
}