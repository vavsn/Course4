using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Figures
{
    class Circle : Point
    {

        private double _area;
        private double _radius;
        public double Radius
        {
            get
            { 
                return _radius; 
            }
            set
            {
                _radius = value;
                _area = Math.PI* Math.Pow(_radius, 2);
            }
        }

        public double Area { get { return _area; } }

        public Circle() : base()
        {
            Radius = 1;
            PositionX = 0;
            PositionY = 0;
            Color = Color.White;
            State = true;
        }

        public Circle(int x, int y, Color c, bool b, double r) : base(x, y, c, b)
        {
            Radius = r;
            PositionX = x;
            PositionY = y;
            Color = c;
            State = b;
        }

        public string ViewState()
        {
            string s = string.Empty;
            s = "Фигура: круг\n";
            s += $"Статус фигуры: {this.GetState()}\n";
            s += $"Позиция горизонт:вертикаль {this.PositionX}:{this.PositionY}\n";
            s += $"Цвет фигуры {this.Color.ToString()}\n";
            s += $"Радиус фигуры {this.Radius}\n";
            s += $"Площадь фигуры {this.Area}\n";
            return s;
        }

    }
}
