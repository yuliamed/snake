using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);//удаление точки хвоста
            Point head = GetNextPoint();
            pList.Add(head);//добавление головы 

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last(); //текущее положение головы змейки
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);//свиг точки в направление движения
            return nextPoint;
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();//будет ли голова в символе еды
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
