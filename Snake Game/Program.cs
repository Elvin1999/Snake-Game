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
        public Snake(int x,int y)
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
        public void wall()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int x = random.Next(1, 39);
            int y = random.Next(1, 39);
            Snake snake = new Snake(x, y);
            snake.showSnake();

        }
    }
}
