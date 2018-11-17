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
        int gameSpeed = 150;
        public Snake(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void showSnake()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)2);
        }
        public bool isGameOn()
        {
            bool isgameon = true;
            return isgameon;
        }
        public bool hitWall()
        {
            bool hitwall = false;
            if (X == 1 || X == 59 || Y == 1 || Y == 29)
            {
                hitwall = true;
            }
            return hitwall;
        }
        public void moveSnake()
        {
            bool isgameon = false;
            ConsoleKey command = Console.ReadKey().Key;
            do
            {
              //  Console.WriteLine($"\t\t\t\t\t\t\t\t X {X} Y {Y}");
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            Console.SetCursorPosition(X, Y);
                            Console.WriteLine(" ");
                            --X;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {
                            Console.SetCursorPosition(X, Y);
                            Console.WriteLine(" ");
                            --Y;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        {
                            Console.SetCursorPosition(X, Y);
                            Console.WriteLine(" ");
                            ++X;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            Console.SetCursorPosition(X, Y);
                            Console.WriteLine(" ");
                            ++Y;
                        }
                        break;
                }
                showSnake();
                isgameon = isGameOn();
                if (hitWall() == true)
                {
                    Console.WriteLine("Game Over");
                    isgameon = false;
                }
                if (Console.KeyAvailable) command = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(gameSpeed);
            } while (isgameon);

        }
        public void wall()
        {
            for (int i = 1; i < 31; i++)
            {
                for (int k = 1; k < 61; k++)
                {
                    if (i == 1 || k == 1 || i == 30 || k == 60)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(k, i);
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
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
            snake.moveSnake();

        }
    }
}
