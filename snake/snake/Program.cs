using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        //private const int Height = 80;

        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, Height);
            VerticalLine VlineLEFT = new VerticalLine(0, 0, 40, '#');
            VlineLEFT.DrawList();
            VerticalLine VlineRIGHT = new VerticalLine(80, 0, 40, '#');
            VlineRIGHT.DrawList();

            HorizontalLine HlineUP = new HorizontalLine(0, 80, 0, '#');
            HlineUP.DrawList();
            HorizontalLine HlineDOWN = new HorizontalLine(0, 80, 40, '#');
            HlineDOWN.DrawList();

            Point p = new Point(4, 5, '+');
            Snake snake = new Snake(p, 14, Direction.RIGHT);
            snake.DrawList();
            Console.ReadLine();
        }
    }
}
