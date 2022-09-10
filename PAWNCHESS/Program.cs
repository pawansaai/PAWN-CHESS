using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Program
    {
        public static string[,] layout = new string[5, 5];
        public static bool currentstat = true;
        public static int whitecoinspoints = 5;
        public static int blackcoinspoints = 5;

        static void Main(string[] args)
        {
            
            PlayerInput.input();
            PlayerInput.initialarrange("blackcoins");
            PlayerInput.initialarrange("whitecoins");

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(layout[i, j] == null || layout[i,j] == " ")
                    {
                        Console.Write("-"+ "   ");
                    }
                    else
                    {
                        Console.Write(layout[i, j] + "  ");
                    }
                    
                }
                Console.WriteLine();
            }
            startgane();
            Console.ReadKey();
        }


        public static void startgane()
        {
            while(currentstat)
            {
                Console.WriteLine("Player1 Input");
                string inp1 = Console.ReadLine();
                Control.move("Player1", inp1);

                Console.WriteLine("Player2 Input");
                string inp2 = Console.ReadLine();
                Control.move2("Player2",inp2);

                Console.WriteLine();

            }
        }

        public static void printboard()
        {
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (layout[i, j] == null || layout[i, j] == " ")
                    {
                        Console.Write("-" + "   ");
                    }
                    else
                    {
                        Console.Write(layout[i, j] + "  ");
                    }

                }
                
                Console.WriteLine();
            }
            if(whitecoinspoints <=0)
            {
                Console.WriteLine("Congratulations!!PLAYER2 won the match");
                
            }

            if(blackcoinspoints <= 0)
            {
                Console.WriteLine("Congratulations!!PLAYER1 won the match");
            }

        }
        
    }
}
