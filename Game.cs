using System;
using System.Collections.Generic;
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

        Paddle Player1 = new Paddle(5, 15, 5);
        Paddle Player2 = new Paddle(115, 15, 5);

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth; //120
            height = Console.WindowHeight; //30
            Console.CursorVisible = false;

            Player1.y = height / 2;
            Player2.y = height / 2;

        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            Player1.Draw();
            Player2.Draw();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                Player2.Move(-1, height, 0);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                Player2.Move(1, height, 0);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                Player1.Move(-1, height, 0);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                Player1.Move(1, height, 0);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
