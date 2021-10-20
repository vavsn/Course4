using System;
using System.IO;

namespace SearchEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithString ws = new WorkWithString();
            string s1 = string.Empty;

            using (StreamWriter w = new StreamWriter(@"d:\Обучение c#\test2.txt"))
            {
                string[] lines = File.ReadAllLines(@"d:\Обучение c#\test.txt");
                foreach (string s in lines)
                {
                    s1 = s;
                    Console.WriteLine($"Строка для обработки: {s1}");
                    try
                    {
                        ws.SearchMail(ref s1);
                        Console.WriteLine($"EMail: {s1}");
                        w.WriteLine(s1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка: {e.Message}");
                    }
                }
            }
        }
    }
}
