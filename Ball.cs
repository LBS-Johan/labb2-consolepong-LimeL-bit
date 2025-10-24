using Labb2_ConsolePong;
using System;
using System.Drawing;
using System.Security.Cryptography;

public class Ball
{
	public int x;
	public int y;
	int xVelocity;
	int yVelocity;
	Game Game = new Game();
	public int p1Score = 0;
	public int p2Score = 0;

	public Ball(int x, int y, int xVelocity, int yVelocity)
	{
		this.x = x;
		this.y = y;
		this.xVelocity = xVelocity;
		this.yVelocity = yVelocity;
	}
	public void Move()
	{
		x += xVelocity;
		y += yVelocity;
	}
	public void Draw()
	{
		Console.SetCursorPosition(x, y);
		Console.Write("()");
	}
	public void CheckCollisions(Paddle p1, Paddle p2, int width, int height)
	{
        //ball collisons cheks

		edgeCollsion(height); //cheks collion on the top and botton walls

		playerCollision(p1, p2); // cheks collision on players

        scoreCollison(width, height); //cheks collsion the the side walls and gives points

    }
        
	void edgeCollsion (int height)
	{
        if (y == height - 1 || y == 0)
        {
            yVelocity *= -1;
        }
    }

	void playerCollision(Paddle p1, Paddle p2)
	{
        if (x == p1.x + 1 || x == p1.x) //player one collsion
        {
            for (int i = 0; i < Game.playerSize; i++)
            {
                if (y == p1.y + i)
                {
                    xVelocity = 1;
                }
            }
        }
        if (x == p2.x - 2 || x == p2.x -1) //player 2 collsion
        {
            for (int i = 0; i < Game.playerSize; i++)
            {
                if (y == p2.y + i)
                {
                    xVelocity = -1;
                }
            }
        }
    }

    void scoreCollison(int width, int height)
    {
        if (x == width - 2)
        {
            p2Score += 1;
            x = width / 2;
            y = height / 2;

        }
        else if (x == 0)
        {
            p1Score += 1;
            x = width / 2;
            y = height / 2;

        }
    }
}


