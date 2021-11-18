using System;
using System.Drawing;

namespace Figures
{
    class Program
    {
        static void ObjectFigure()
        {
            Figure f = new Figure();

            Console.WriteLine(f.ViewState());
            Console.WriteLine();

            f.MoveXY(15, 10);
            f.Color = Color.Red;
            f.State = false;

            Console.WriteLine(f.ViewState());
            Console.WriteLine();

            f.MoveXY(-5, -50);

            Console.WriteLine(f.ViewState());
            Console.WriteLine();

            f = new Figure(23, -6, Color.AntiqueWhite, true);

            Console.WriteLine(f.ViewState());
        }

        static void ObjectPoint()
        {
            Point p = new Point();

            Console.WriteLine(p.ViewState());
            Console.WriteLine();

            p.MoveXY(-5, -50);

            Console.WriteLine(p.ViewState());
            Console.WriteLine();

            p = new Point(19, 19, Color.Goldenrod, false);

            Console.WriteLine(p.ViewState());
            Console.WriteLine();

            p.Up();
            p.Left();

            Console.WriteLine(p.ViewState());
        }

        static void ObjectCircle()
        {
            Circle c = new Circle();

            Console.WriteLine(c.ViewState());
            Console.WriteLine();

            c.MoveXY(6, 30);

            Console.WriteLine(c.ViewState());
            Console.WriteLine();

            c = new Circle(14, 14, Color.Goldenrod, true, 4.5);

            Console.WriteLine(c.ViewState());
            Console.WriteLine();

            c.Down();
            c.Right();
            c.Radius = 7D;

            Console.WriteLine(c.ViewState());
        }

        static void ObjectRectangle()
        {
            Rectangle r = new Rectangle();

            Console.WriteLine(r.ViewState());
            Console.WriteLine();

            r.MoveXY(6, 30);

            Console.WriteLine(r.ViewState());
            Console.WriteLine();

            r = new Rectangle(14, 14, Color.Goldenrod, true, 4.5, 5);

            Console.WriteLine(r.ViewState());
            Console.WriteLine();

            r.Down();
            r.Right();
            r.Length = 3D;
            r.Width = 4.5;

            Console.WriteLine(r.ViewState());
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Объект - ФИГУРА");
            ObjectFigure();
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Объект - ТОЧКА");
            ObjectPoint();
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Объект - КРУГ");
            ObjectCircle();
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Объект - ПРЯМОУГОЛЬНИК");
            ObjectRectangle();
            Console.ReadLine();

        }
    }
}
