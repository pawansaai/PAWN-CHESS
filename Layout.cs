using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Layout
    {
        public static string[,] boxes = new string[6,4];
        public static string[] whitecoins = new string[] { "W1", "W2", "W3", "W4" };
        public static string[] blackcoins = new string[] { "B1", "B2", "B3", "B4" };
        public static int whitepoints = 4;
        public static int blackpoints = 4;

        public static void board()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    boxes[i, j] = "-";
                }
            }

        }
        
        public static void Player1Coins()
        {
            for (int i = 0; i < 4; i++)
            {
                boxes[5, i] = whitecoins[i];
            }
        }
        public static void Player2Coins()
        {
            for (int i = 0; i < 4; i++)
            {
                boxes[0, i] = blackcoins[i];
            }
        }
        public static void boardprint()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(boxes[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }


        public static void InputTaking()
        {
            while(whitepoints!=0 && blackpoints != 0)
            {

                Console.Write("Player1 select coin - (W1 TO W4):- ");
                string coin1 = Console.ReadLine();
                Console.Write("Enter Direction(F|B|L|R):- ");
                string move1 = Console.ReadLine();

                int posx1 = 0, posy1 = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (boxes[i, j] == coin1)
                        {
                            posx1 = i;
                            posy1 = j;
                        }
                    }
                }

                switch (coin1)
                {
                    case "W1":
                        switch (move1)
                        {
                            case "F":
                                if (boxes[posx1 - 1, posy1] == "B1" || boxes[posx1 - 1, posy1] == "B2" || boxes[posx1 - 1, posy1] == "B3" || boxes[posx1 - 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 - 1, posy1] = "-";
                                }
                                boxes[posx1 - 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "B":
                                if (boxes[posx1 + 1, posy1] == "B1" || boxes[posx1 + 1, posy1] == "B2" || boxes[posx1 + 1, posy1] == "B3" || boxes[posx1 + 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 + 1, posy1] = "-";
                                }
                                boxes[posx1 + 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "L":
                                if (boxes[posx1, posy1 - 1] == "B1" || boxes[posx1, posy1 - 1] == "B2" || boxes[posx1, posy1 - 1] == "B3" || boxes[posx1, posy1 - 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 - 1] = "-";
                                }
                                boxes[posx1, posy1 - 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "R":
                                if (boxes[posx1, posy1 + 1] == "B1" || boxes[posx1, posy1 + 1] == "B2" || boxes[posx1, posy1 + 1] == "B3" || boxes[posx1, posy1 + 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 + 1] = "-";
                                }
                                boxes[posx1, posy1 + 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "W2":
                        switch (move1)
                        {
                            case "F":
                                if (boxes[posx1 - 1, posy1] == "B1" || boxes[posx1 - 1, posy1] == "B2" || boxes[posx1 - 1, posy1] == "B3" || boxes[posx1 - 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 - 1, posy1] = "-";
                                }
                                boxes[posx1 - 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "B":
                                if (boxes[posx1 + 1, posy1] == "B1" || boxes[posx1 + 1, posy1] == "B2" || boxes[posx1 + 1, posy1] == "B3" || boxes[posx1 + 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 + 1, posy1] = "-";
                                }
                                boxes[posx1 + 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "L":
                                if (boxes[posx1, posy1 - 1] == "B1" || boxes[posx1, posy1 - 1] == "B2" || boxes[posx1, posy1 - 1] == "B3" || boxes[posx1, posy1 - 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 - 1] = "-";
                                }
                                boxes[posx1, posy1 - 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "R":
                                if (boxes[posx1, posy1 + 1] == "B1" || boxes[posx1, posy1 + 1] == "B2" || boxes[posx1, posy1 + 1] == "B3" || boxes[posx1, posy1 + 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 + 1] = "-";
                                }
                                boxes[posx1, posy1 + 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "W3":
                        switch (move1)
                        {
                            case "F":
                                if (boxes[posx1 - 1, posy1] == "B1" || boxes[posx1 - 1, posy1] == "B2" || boxes[posx1 - 1, posy1] == "B3" || boxes[posx1 - 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 - 1, posy1] = "-";
                                }
                                boxes[posx1 - 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "B":
                                if (boxes[posx1 + 1, posy1] == "B1" || boxes[posx1 + 1, posy1] == "B2" || boxes[posx1 + 1, posy1] == "B3" || boxes[posx1 + 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 + 1, posy1] = "-";
                                }
                                boxes[posx1 + 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "L":
                                if (boxes[posx1, posy1 - 1] == "B1" || boxes[posx1, posy1 - 1] == "B2" || boxes[posx1, posy1 - 1] == "B3" || boxes[posx1, posy1 - 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 - 1] = "-";
                                }
                                boxes[posx1, posy1 - 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "R":
                                if (boxes[posx1, posy1 + 1] == "B1" || boxes[posx1, posy1 + 1] == "B2" || boxes[posx1, posy1 + 1] == "B3" || boxes[posx1, posy1 + 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 + 1] = "-";
                                }
                                boxes[posx1, posy1 + 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "W4":
                        switch (move1)
                        {
                            case "F":
                                if (boxes[posx1 - 1, posy1] == "B1" || boxes[posx1 - 1, posy1] == "B2" || boxes[posx1 - 1, posy1] == "B3" || boxes[posx1 - 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 - 1, posy1] = "-";
                                }
                                boxes[posx1 - 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "B":
                                if (boxes[posx1 + 1, posy1] == "B1" || boxes[posx1 + 1, posy1] == "B2" || boxes[posx1 + 1, posy1] == "B3" || boxes[posx1 + 1, posy1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1 + 1, posy1] = "-";
                                }
                                boxes[posx1 + 1, posy1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "L":
                                if (boxes[posx1, posy1 - 1] == "B1" || boxes[posx1, posy1 - 1] == "B2" || boxes[posx1, posy1 - 1] == "B3" || boxes[posx1, posy1 - 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 - 1] = "-";
                                }
                                boxes[posx1, posy1 - 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            case "R":
                                if (boxes[posx1, posy1 + 1] == "B1" || boxes[posx1, posy1 + 1] == "B2" || boxes[posx1, posy1 + 1] == "B3" || boxes[posx1, posy1 + 1] == "B4")
                                {
                                    blackpoints--;
                                    boxes[posx1, posy1 + 1] = "-";
                                }
                                boxes[posx1, posy1 + 1] = boxes[posx1, posy1];
                                boxes[posx1, posy1] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid coin");
                        break;
                }


                Console.WriteLine(whitepoints);
                Console.WriteLine(blackpoints);

                Layout.boardprint();



                Console.Write("Player2 select coin - (B1 TO B4):- ");
                string coin2 = Console.ReadLine();
                Console.Write("Enter Direction(F|B|L|R):- ");
                string move2 = Console.ReadLine();

                int posx2 = 0, posy2 = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (boxes[i, j] == coin2)
                        {
                            posx2 = i;
                            posy2 = j;
                        }
                    }
                }

                switch (coin2)
                {
                    case "B1":
                        switch (move2)
                        {
                            case "F":
                                if (boxes[posx2 + 1, posy2] == "W1" || boxes[posx2 + 1, posy2] == "W2" || boxes[posx2 + 1, posy2] == "W3" || boxes[posx2 + 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 + 1, posy2] = "-";
                                }
                                boxes[posx2 + 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "B":
                                if (boxes[posx2 - 1, posy2] == "W1" || boxes[posx2 - 1, posy2] == "W2" || boxes[posx2 - 1, posy2] == "W3" || boxes[posx2 - 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 - 1, posy2] = "-";
                                }
                                boxes[posx2 - 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "L":
                                if (boxes[posx2, posy2 - 1] == "W1" || boxes[posx2, posy2 - 1] == "W2" || boxes[posx2, posy2 - 1] == "W3" || boxes[posx2, posy2 - 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 - 1] = "-";
                                }
                                boxes[posx2, posy2 - 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "R":
                                if (boxes[posx2, posy2 + 1] == "W1" || boxes[posx2, posy2 + 1] == "W2" || boxes[posx2, posy2 + 1] == "W3" || boxes[posx2, posy2 + 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 + 1] = "-";
                                }
                                boxes[posx2, posy2 + 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "B2":
                        switch (move2)
                        {
                            case "F":
                                if (boxes[posx2 + 1, posy2] == "W1" || boxes[posx2 + 1, posy2] == "W2" || boxes[posx2 + 1, posy2] == "W3" || boxes[posx2 + 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 + 1, posy2] = "-";
                                }
                                boxes[posx2 + 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "B":
                                if (boxes[posx2 - 1, posy2] == "W1" || boxes[posx2 - 1, posy2] == "W2" || boxes[posx2 - 1, posy2] == "W3" || boxes[posx2 - 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 - 1, posy2] = "-";
                                }
                                boxes[posx2 - 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "L":
                                if (boxes[posx2, posy2 - 1] == "W1" || boxes[posx2, posy2 - 1] == "W2" || boxes[posx2, posy2 - 1] == "W3" || boxes[posx2, posy2 - 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 - 1] = "-";
                                }
                                boxes[posx2, posy2 - 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "R":
                                if (boxes[posx2, posy2 + 1] == "W1" || boxes[posx2, posy2 + 1] == "W2" || boxes[posx2, posy2 + 1] == "W3" || boxes[posx2, posy2 + 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 + 1] = "-";
                                }
                                boxes[posx2, posy2 + 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "B3":
                        switch (move2)
                        {
                            case "F":
                                if (boxes[posx2 + 1, posy2] == "W1" || boxes[posx2 + 1, posy2] == "W2" || boxes[posx2 + 1, posy2] == "W3" || boxes[posx2 + 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 + 1, posy2] = "-";
                                }
                                boxes[posx2 + 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "B":
                                if (boxes[posx2 - 1, posy2] == "W1" || boxes[posx2 - 1, posy2] == "W2" || boxes[posx2 - 1, posy2] == "W3" || boxes[posx2 - 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 - 1, posy2] = "-";
                                }
                                boxes[posx2 - 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "L":
                                if (boxes[posx2, posy2 - 1] == "W1" || boxes[posx2, posy2 - 1] == "W2" || boxes[posx2, posy2 - 1] == "W3" || boxes[posx2, posy2 - 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 - 1] = "-";
                                }
                                boxes[posx2, posy2 - 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "R":
                                if (boxes[posx2, posy2 + 1] == "W1" || boxes[posx2, posy2 + 1] == "W2" || boxes[posx2, posy2 + 1] == "W3" || boxes[posx2, posy2 + 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 + 1] = "-";
                                }
                                boxes[posx2, posy2 + 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    case "B4":
                        switch (move2)
                        {
                            case "F":
                                if (boxes[posx2 + 1, posy2] == "W1" || boxes[posx2 + 1, posy2] == "W2" || boxes[posx2 + 1, posy2] == "W3" || boxes[posx2 + 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 + 1, posy2] = "-";
                                }
                                boxes[posx2 + 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "B":
                                if (boxes[posx2 - 1, posy2] == "W1" || boxes[posx2 - 1, posy2] == "W2" || boxes[posx2 - 1, posy2] == "W3" || boxes[posx2 - 1, posy2] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2 - 1, posy2] = "-";
                                }
                                boxes[posx2 - 1, posy2] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "L":
                                if (boxes[posx2, posy2 - 1] == "W1" || boxes[posx2, posy2 - 1] == "W2" || boxes[posx2, posy2 - 1] == "W3" || boxes[posx2, posy2 - 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 - 1] = "-";
                                }
                                boxes[posx2, posy2 - 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            case "R":
                                if (boxes[posx2, posy2 + 1] == "W1" || boxes[posx2, posy2 + 1] == "W2" || boxes[posx2, posy2 + 1] == "W3" || boxes[posx2, posy2 + 1] == "W4")
                                {
                                    whitepoints--;
                                    boxes[posx2, posy2 + 1] = "-";
                                }
                                boxes[posx2, posy2 + 1] = boxes[posx2, posy2];
                                boxes[posx2, posy2] = "-";
                                break;
                            default:
                                Console.WriteLine("Enter valid move");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Enter valid coin");
                        break;

                }
                Console.WriteLine(whitepoints);
                Console.WriteLine(blackpoints);

                Layout.boardprint();

            }
             

        }

    }
}
