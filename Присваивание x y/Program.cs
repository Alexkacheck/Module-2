using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Присваивание_x_y
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int x = 10;
            int y = 2;

            f(ref a, ref b, x, y);

            Console.WriteLine($"a = {a}, b = {b}");
        }

        static void f(ref int a, ref int b, int x, int y)
        {
            if (y != 0)
            {
                a = x * y;
                b = x / y;
            }
            else
            {
                // Обработка случая, когда y равно нулю.
                Console.WriteLine("Деление на ноль!");
            }
        }
    }
}
