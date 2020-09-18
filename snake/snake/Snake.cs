﻿using System;
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
    }
}
