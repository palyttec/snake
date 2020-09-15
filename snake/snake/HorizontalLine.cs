﻿using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void  Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
