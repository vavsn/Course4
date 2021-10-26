using System;
using static System.Net.Mime.MediaTypeNames;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b1 = new Building();
            try
            {
                b1.SetNum(5);
                b1.SetHeight(21);
                b1.SetCountFloor(5);
                b1.SetCountFlat(40);
                b1.SetCountEntrance(3);
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"{e.Message}");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Создано здание 1:");
            Console.WriteLine($"Порядковый номер здания: {b1.GetNum()}");
            Console.WriteLine($"Высота здания: {b1.GetHeight()}");
            Console.WriteLine($"Количество этажей здания: {b1.GetCountFloor()}");
            Console.WriteLine($"Высота этажа здания: {b1.GetHeightFloor()}");
            Console.WriteLine($"Количество подъездов в здании: {b1.GetCountEntrance()}");
            Console.WriteLine($"Количество квартир в здании: {b1.GetCountFlat()}");
            Console.WriteLine($"Количество квартир на этаже: {b1.GetCountFlatOnFloor()}");
            Console.WriteLine($"Количество квартир в подъезде: {b1.GetCountFlatOnEntrance()}");
            if (!b1.GetErgonomic())
            {
                Console.WriteLine("Обратите внимание: высота этажа не отвечает требованиям эргономичности!");
            }

            Building b2 = new Building();
            try
            {
                b1.AutoSetNum();
                b1.SetHeight(11);
                b1.SetCountFloor(5);
                b1.SetCountFlat(50);
                b1.SetCountEntrance(8);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"{e.Message}");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Создано здание 2:");
            Console.WriteLine($"Порядковый номер здания: {b1.GetNum()}");
            Console.WriteLine($"Высота здания: {b1.GetHeight()}");
            Console.WriteLine($"Количество этажей здания: {b1.GetCountFloor()}");
            Console.WriteLine($"Высота этажа здания: {b1.GetHeightFloor()}");
            Console.WriteLine($"Количество подъездов в здании: {b1.GetCountEntrance()}");
            Console.WriteLine($"Количество квартир в здании: {b1.GetCountFlat()}");
            Console.WriteLine($"Количество квартир на этаже: {b1.GetCountFlatOnFloor()}");
            Console.WriteLine($"Количество квартир в подъезде: {b1.GetCountFlatOnEntrance()}");
            if (!b2.GetErgonomic())
            {
                Console.WriteLine("Обратите внимание: высота этажа не отвечает требованиям эргономичности!");
            }

        }
    }
}
