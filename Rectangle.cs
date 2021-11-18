using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Figures
{
    class Rectangle: Point
    {
        private double _length;
        private double _width;
        private double _area;

        public double Length 
        {
            get { return _length; }
            set
            {
                _length = value;
                _area = _length * _width;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                _width = value;
                _area = _length * _width;
            }
        }

        public double Area { get { return _area; } }

        public Rectangle() : base()
        {
            PositionX = 0;
            PositionY = 0;
            Color = Color.White;
            State = true;
        }

        public Rectangle(int x, int y, Color c, bool b, double l, double w) : base(x, y, c, b)
        {
            Length = l;
            Width = w;
            PositionX = x;
            PositionY = y;
            Color = c;
            State = b;
        }

        public string ViewState()
        {
            string s = string.Empty;
            s = "Фигура: прямоугольник\n";
            s += $"Статус фигуры: {this.GetState()}\n";
            s += $"Позиция горизонт:вертикаль {this.PositionX}:{this.PositionY}\n";
            s += $"Цвет фигуры {this.Color.ToString()}\n";
            s += $"Длина фигуры {this.Length}\n";
            s += $"Ширина фигуры {this.Width}\n";
            s += $"Площадь фигуры {this.Area}\n";
            return s;
        }
    }
}
