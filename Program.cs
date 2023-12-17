using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHESS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Layout.board();
            Layout.Player1Coins();
            Layout.Player2Coins();
            Layout.boardprint();


            Layout.InputTaking();


            if (Layout.whitepoints == 0)
            {
                Console.WriteLine("Congrats!! Player2(black) won the match");

            }
            if (Layout.blackpoints == 0)
            {
                Console.WriteLine("Congrats!! Player1(white) won the match");

            }




            Console.ReadLine();
            Console.ReadLine();

            //bool fix = true;
            //bool pred1()
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            if (Layout.boxes[i, j] == "W1" || Layout.boxes[i, j] == "W2" || Layout.boxes[i, j] == "W3" || Layout.boxes[i, j] == "W4")
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //    return false;
            //}
            //bool pred2()
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            if (Layout.boxes[i, j] == "B1" || Layout.boxes[i, j] == "B2" || Layout.boxes[i, j] == "B3" || Layout.boxes[i, j] == "B4")
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //    return false;
            //}

            //bool predValue1 = pred1();
            //bool predValue2 = pred2();

            //while(predValue1 && predValue2)
            //{
            //    fix = true;
            //}
            //while (fix)
            //{
            //    Layout.InputTaking();
            //}


            //if (predValue1 == false)
            //{
            //    Layout.whitepoints = 0;
            //}
            //if (predValue2 == false)
            //{
            //    Layout.blackpoints = 0;
            //}




            //if (Layout.whitepoints != 0 && Layout.blackpoints != 0)
            //{
            //    Layout.InputTaking();
            //}

        }

    }
}
