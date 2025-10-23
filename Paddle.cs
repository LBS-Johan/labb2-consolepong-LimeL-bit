using System;
using System.Security.Cryptography.X509Certificates;

public class Paddle
{
    public int x;
    public int y;
    public int size;

    public Paddle(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;
    }

    public void Move(int yAmount, int maxy, int miny)
    {
        if (yAmount == -1) // upp
        {
            if (y > miny)
            y -= 1;
        }
        else if (yAmount == 1) // ner
        {
            if (y + size - 1 < maxy)
            y += 1;
        }
        
    }

    public void Draw()
    {
        for (int i = 0; i < size; i++)
        {
            Console.SetCursorPosition(x, y + i);
            Console.Write("|");
        }
    }
}
