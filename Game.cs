using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle p1 = new Paddle(5, 15, 5);
        Paddle p2 = new Paddle(115, 15, 5);

        public void StartGame()
        {
            width = Console.WindowWidth; //120
            height = Console.WindowHeight; //30
            Console.CursorVisible = false;

            p1.y = height / 2;
            p2.y = height / 2;

            
            // gör backgrunden vit vid paddlen för hel färg :D
        }

        public bool Run()
        {
            Console.Clear();

            p1.Draw(ConsoleColor.Red);
            p2.Draw(ConsoleColor.Blue);
            bacground();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                p2.Move(-1, height, 0);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                p2.Move(1, height, 0);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                p1.Move(-1, height, 0);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                p1.Move(1, height, 0);
            }



            //Return true om spelet ska fortsätta
            return true;

        }

        public void bacground()
        {
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(">");

                Console.SetCursorPosition(width / 2 - 1, i);
                Console.Write("| |");

                Console.SetCursorPosition(width - 1, i);
                Console.Write("<");
            }
        }
    }
}
