using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_нечетных_целых_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M:");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            int N = int.Parse(Console.ReadLine());

            int result = f(M, N);

            Console.WriteLine($"Сумма нечетных чисел в диапазоне от {M} до {N} равна {result}");
        }

        static int f(int M, int N)
        {
            int sum = 0;

            for (int i = M; i <= N; i++)
            {
                if (i % 2 != 0) //  является ли число нечетным
                {
                    sum += i; // Добавляем нечетное число к сумме.
                }
            }

            return sum;
        }
    }
}
