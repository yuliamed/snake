using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        private static object key;

        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, Height);
            VerticalLine VlineLEFT = new VerticalLine(0, 0, 30, '#');
            VlineLEFT.DrawList();
            VerticalLine VlineRIGHT = new VerticalLine(40, 0, 30, '#');
            VlineRIGHT.DrawList();

            HorizontalLine HlineUP = new HorizontalLine(0, 40, 0, '#');
            HlineUP.DrawList();
            HorizontalLine HlineDOWN = new HorizontalLine(0, 40, 30, '#');
            HlineDOWN.DrawList();

            Point p = new Point(1, 1, '+');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawList();

            FoodCreator foodCreator = new FoodCreator(40, 30, '%');
            Point food = foodCreator.CreatFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreatFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
