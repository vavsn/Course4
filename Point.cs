using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace Figures
{
    class Point : Figure
    {
        public string Name = "точка";

        public Point() :base()
        {
            PositionX = 0;
            PositionY = 0;
            Color = Color.White;
            State = true;
        }

        public Point(int x, int y, Color c, bool b): base(x, y, c, b)
        {
            PositionX = x;
            PositionY = y;
            Color = c;
            State = b;
        }

        public string ViewState()
        {
            string s = string.Empty;
            s = "Фигура: точка\n";
            s += $"Статус фигуры: {this.GetState()}\n";
            s += $"Позиция горизонт:вертикаль {this.PositionX}:{this.PositionY}\n";
            s += $"Цвет фигуры {this.Color.ToString()}\n";
            return s;
        }
    }
}
