using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);


            FoodCreator foodCreator = new FoodCreator(70, 15, '^');
            Point food = foodCreator.CreateFood();
            food.Drow();

            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 2, Direction.RIGHT);
            Walls walls = new Walls(80, 25);
            walls.Drow();
            snake.Drow();
           
            while (true)
            {
                if(walls.IsHit(snake)|| snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Drow();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Mandlekey(key.Key);
                }
                Thread.Sleep(100);
               snake.Move();
            }
            

            //Point p2 = new Point(4,5,'%');

            //Point cp1 = new Point(11, 5, '#');
            //Point cp2 = new Point(-3, 15, '#');
            //Point cp3 = new Point(6, 0, '#');
            //Point cp4 = new Point(2, 10, '#');

            //p2.Drow();
            //List<Point> pList = new List<Point>();
            //pList.Add(p1);
            //pList.Add(p2);

            //List<Point> Cheef = new List<Point>();
            //Cheef.Add(cp1);
            //Cheef.Add(cp2);
            //Cheef.Add(cp3);

            //List<char> sym = new List<char>();
            //sym.Add('*');
            //sym.Add('$');
            //sym.Add('@');
            //char sym1 = sym[0];
            //char sym2 = sym[1];
            //char sym3 = sym[2];

            //List<int> numList = new List<int>();
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);
            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            //Console.ReadLine();

        }

    }
}
