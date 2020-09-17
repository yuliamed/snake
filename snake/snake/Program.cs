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
            VerticalLine Vline = new VerticalLine(6, 2, 8, '+');
            Vline.DrawList();

            HorizontalLine Hline = new HorizontalLine(5, 10, 8, '_');
            Hline.DrawList();
            Console.ReadLine();
        }
    }
}
