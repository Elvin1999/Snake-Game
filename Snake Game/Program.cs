using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class Snake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Snake(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void showSnake()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)2); Console.WriteLine(); Console.WriteLine();
        }
        public void wall()
        {
            for (int i = 0; i < 31; i++)
            {
                for (int k = 0; k < 61; k++)
                {
                    if (i == 0 || k == 0 || i==30 ||k==60)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(k, i);
                        Console.WriteLine("* ");
                    }

                }
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(1, 51);
            int y = random.Next(1, 31);
            Snake snake = new Snake(x, y); snake.showSnake();
            snake.wall();


        }
    }
}
