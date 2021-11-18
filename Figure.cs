using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figures
{
    class Figure
    {
        public int PositionX;

        public int PositionY;

        private Color _color;

        private bool _state;


        public bool State
        {
            set { _state = value; }
        }

        public string GetState()
        {
            return _state? "видимая" : "невидимая";
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set 
            {
                _color = value;
            }
        }

        public Figure()
        {
            PositionX = 0;
            PositionY = 0;
            Color = Color.White;
            State = true;
        }

        public Figure(int x, int y, Color c, bool b)
        {
            PositionX = x;
            PositionY = y;
            Color = c;
            State = b;
        }

        /// <summary>
        /// вперед по одной оси => положительное значение одной переменной, 0 во второй переменной
        /// назад по одной оси => отрицательное значение одной переменной, 0 во второй переменной
        /// вперед по обоим осям => положительные значения переменных
        /// назад по обоим осям => отрицательные значения переменных
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveXY(int x, int y)
        {
            PositionX += x;
            PositionY += y;
        }
        public void Up()
        {
            MoveXY(0,1);
        }

        public void Down()
        {
            MoveXY(0, -1);
        }

        public void Right()
        {
            MoveXY(1, 0);
        }

        public void Left()
        {
            MoveXY(-1, 0);
        }

        public string  ViewState()
        {
            string s = string.Empty;
            s = $"Статус фигуры: {this.GetState()} \n";
            s += $"Позиция горизонт:вертикаль {PositionX}:{PositionY}\n";
            s += $"Цвет фигуры {Color.ToString()}\n";
            return s;
        }
    }
}
