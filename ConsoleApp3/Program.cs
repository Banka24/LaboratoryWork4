using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0, x, a;

            Console.Write("Введите х: ");
            x = double.Parse(Console.ReadLine());
            a = x;
            for(int i = 1; i <= 7; i++)
            {
                s = i % 2 != 0 ? s + a : s - a;
                a *= x * x / (2 * i * (2 * i + 1));
            }
            Console.WriteLine($"S = {s:f3}");
        }
    }
}
