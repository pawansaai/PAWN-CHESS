using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWNCHESS
{
    internal class Control
    {
        public static string controlcom;

        public static int move(string player,string inp)
        {
            string[] temp = inp.Split(':');

            if(player == "Player1")
            {
                for(int i = 0; i<5; i++)
                {
                    for(int j = 0;j<5;j++)
                    {
                        if(Program.layout[i,j] == temp[0])
                        {
                            switch(temp[1])
                            {
                                case "L":
                                    Program.layout[i, j - 1] = Program.layout[i, j];
                                    Program.layout[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.layout[i, j - 1]))
                                    {
                                        Program.blackcoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.layout[i,j + 1] = Program.layout[i, j];
                                    Program.layout[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.layout[i, j + 1]))
                                    {
                                        Program.blackcoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.layout[i - 1, j] = Program.layout[i, j];
                                    Program.layout[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.layout[i - 1, j]))
                                    {
                                        Program.blackcoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.layout[i + 1, j] = Program.layout[i, j];
                                    Program.layout[i,j] = " ";
                                    if (PlayerInput.whitecoins.Contains(Program.layout[i + 1, j]))
                                    {
                                        Program.blackcoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                
                            }
                            return 0;
                            //switch case
                            //move coin
                        }

                    }

                }

            }
            return 0;
        }

        public static int move2(string player, string inp)
        {
            string[] temp1 = inp.Split(':');

            if (player == "Player2")
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 5; l++)
                    {
                        //Console.WriteLine(k);
                        //Console.WriteLine(l);
                        //Console.WriteLine(Program.layout[k, l]);
                        //Console.WriteLine(temp1[0]);
                        //Console.ReadKey();
                        if(Program.layout[k, l] == temp1[0])
                        {
                            //switch case
                            switch (temp1[1])
                            {
                                case "L":
                                    Program.layout[k, l - 1] = Program.layout[k, l];
                                    Program.layout[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.layout[k, l - 1]))
                                    {
                                        Program.whitecoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "R":
                                    Program.layout[k, l + 1] = Program.layout[k, l];
                                    Program.layout[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.layout[k, l + 1]))
                                    {
                                        Program.whitecoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "F":
                                    Program.layout[k + 1, l] = Program.layout[k, l];
                                    Program.layout[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.layout[k + 1, l]))
                                    {
                                        Program.whitecoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                                case "B":
                                    Program.layout[k - 1, l] = Program.layout[k, l];
                                    Program.layout[k, l] = " ";
                                    if (PlayerInput.blackcoins.Contains(Program.layout[k - 1, l]))
                                    {
                                        Program.whitecoinspoints = Program.blackcoinspoints - 1;
                                    }
                                    Program.printboard();
                                    return 0;
                            }

                        }
                    }
                }
            }
            return 0;
        }
    }
}
