using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Омы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сопротивление первого участка (R1) в омах:");
            double R1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение первого участка (U1) в вольтах:");
            double U1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сопротивление второго участка (R2) в омах:");
            double R2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите напряжение второго участка (U2) в вольтах:");
            double U2 = double.Parse(Console.ReadLine());

            double I1 = U1 / R1; // Расчет тока на первом участке
            double I2 = U2 / R2; // Расчет тока на втором участке

            if (I1 < I2)
            {
                Console.WriteLine("Ток на первом участке меньше.");
            }
            else if (I2 < I1)
            {
                Console.WriteLine("Ток на втором участке меньше.");
            }
            else
            {
                Console.WriteLine("Токи на обоих участках равны.");
            }
        }
    }
}