using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class PlayerInput
    {
        public static string[] whitecoins = new string[5];
        public static string[] blackcoins = new string[5];
        public static void input()
        {

            Console.WriteLine("ENTER PLAYER1 CHAR");
            for(int i = 0; i < 5; i++)
            {
                string temp = Console.ReadLine();
                whitecoins[i] = temp;
                //whitecoins.Append(temp);
            }

            Console.WriteLine("ENTER PLAYER2 CHAR");
            for (int i = 0; i < 5; i++)
            {
                string temp1 = Console.ReadLine();
                blackcoins[i] = temp1;
                //blackcoins.Append(temp);
            }

        }

        public static void initialarrange(string str)
        {
            if (str == "blackcoins")
            {
                for(int i = 0; i < 5; i++)
                {
                    Program.layout[0,i] = blackcoins[i];
                }
            }
            if (str == "whitecoins")
            {
                for(int A = 0; A < 5; A++)
                {
                    Program.layout[4, A] = whitecoins[A];
                }
            }
        }
    }
}
