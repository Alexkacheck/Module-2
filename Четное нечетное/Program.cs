using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четное_нечетное
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
          

            bool result1 = even(a);
            bool result2 = even(b);

            Console.WriteLine($"{a} Четное число? {result1}");
            Console.WriteLine($"{b} Четное число? {result2}");
        }

        static bool even(int n)
        {
            return n % 2 == 0;
        }
    }
}
