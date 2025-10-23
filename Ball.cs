using System;

public class Ball
{
    public int x;
	public int y;
	int xVelocity;
	int yVelocity;


    public Ball(int x,int y,int xVelocity, int yVelocity)
	{
		this.x = x;
		this.y = y;
		this.xVelocity = xVelocity;
		this.yVelocity = yVelocity;
	}
    public void Move()
	{

	}
    public void Draw()
	{

	}
    public void CheckCollisions(Paddle p1, Paddle p2, int width, int height)
	{

	}
}


