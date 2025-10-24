using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labb2_ConsolePong
{
    internal class numberOutputer
    {
        static string[][] numberDesigns = new string[10][];
        int startX;
        int startY;

        public void NumbetText(int number, Paddle p1, Paddle p2, bool P1TorP2F)
        {
            saveNumbers();
            numberHandeling(number,p1,p2,P1TorP2F);
        }

        public void numberHandeling(int number, Paddle p1, Paddle p2, bool P1TorP2F)
        {
            if (number >= 0 && number <= 9)
            {
                if (number < 0 || number > 9) return;
                string[] design = numberDesigns[number];
                

                if (P1TorP2F == true)
                {
                    startX = p1.x + 30;
                    startY = 1;
                }
                else if(P1TorP2F == false)
                {
                    startX = p2.x - 35;
                    startY = 1;
                }

                for (int i = 0; i < design.Length; i++)
                {
                    Console.SetCursorPosition(startX, startY + i);
                    Console.Write(design[i]);
                }


            }
        }

        public void saveNumbers()
        {
            string[] design0 = {
            " ### ",
            "#   #",
            "#   #",
            "#   #",
            " ### "
        };

            string[] design1 = {
            "  #  ",
            " ##  ",
            "  #  ",
            "  #  ",
            " ### "
        };

            string[] design2 = {
            " ### ",
            "    #",
            " ### ",
            "#    ",
            "#####"
        };
            string[] design3 = {
            "#### ",
            "    #",
            " ### ",
            "    #",
            "#### "
        };
            string[] design4 = {
            "#  # ",
            "#  # ",
            "#####",
            "   # ",
            "   # "
        };
            string[] design5 = {
            "#####",
            "#    ",
            "#### ",
            "    #",
            "#### "
        };
            string[] design6 = {
            " ### ",
            "#    ",
            "#### ",
            "#   #",
            " ### "
        };
            string[] design7 = {
            "#####",
            "   # ",
            "  #  ",
            " #   ",
            " #   "
        };
            string[] design8 = {
            " ### ",
            "#   #",
            " ### ",
            "#   #",
            " ### "
        };
            string[] design9 = {
            " ### ",
            "#   #",
            " ####",
            "    #",
            " ### "
        };

            numberDesigns[0] = design0;
            numberDesigns[1] = design1;
            numberDesigns[2] = design2;
            numberDesigns[3] = design3;
            numberDesigns[4] = design4;
            numberDesigns[5] = design5;
            numberDesigns[6] = design6;
            numberDesigns[7] = design7;
            numberDesigns[8] = design8;
            numberDesigns[9] = design9;

        }
    }
}
