using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конец диапазона чисел Фибоначчи от 1 до : ");
            int n = int.Parse(Console.ReadLine());
            int u, u1 = 0, u2 = 1;
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            for (int i = 2; i < n; i++)
            {
                u = u1 + u2;
                u1 = u2;
                u2 = u;
                Console.WriteLine(u);
            }

            Console.ReadKey();
        }
    }
}


