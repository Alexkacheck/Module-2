using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Часы_секунды_минуты
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите часы:");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минуты:");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите секунды:");
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = f(hours, minutes, seconds);

            Console.WriteLine($"Секунд, прошедших с начала дня: {totalSeconds}");
        }

        static int f(int h, int m, int s)
        {
            if (h >= 0 && h <= 23 && m >= 0 && m <= 59 && s >= 0 && s <= 59)
            {
                int totalSeconds = h * 3600 + m * 60 + s;
                return totalSeconds;
            }
            else
            {
                Console.WriteLine("Некорректное значение времени.");
                return -1; // или какое-то другое значение по умолчанию
            }
        }
    }
}


