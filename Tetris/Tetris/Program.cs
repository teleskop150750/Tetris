﻿using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2;
            int y1 = 3;
            char c1 = '*';

            Draw(x1, y1, c1);

            Console.ReadLine();
        }

        private static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }

}
