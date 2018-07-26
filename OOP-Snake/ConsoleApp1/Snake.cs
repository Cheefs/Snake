using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Direction direction;
        public Snake(Point tail,int lenght, Direction direction)
        {
           this.direction = direction;
           
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i,direction);
                pList.Add(p);
            }
               
        }
        internal bool IsHitTail()
        {
            var head = pList.Last();

            for (int i = 1; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i])) return true;
            }
            return false;    
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void Mandlekey(ConsoleKey key)
        {
    
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            
            if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
          
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
            
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
            
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
               
                pList.Add(food);
                return true;
            }
            return false;
        }
    }
}
