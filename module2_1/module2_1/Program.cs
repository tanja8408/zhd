using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число компаний, работающих в стране:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент налога:");
            int procent = Convert.ToInt32(Console.ReadLine());
            int dohod = 500;
            int sum = dohod * number * procent / 100;
            Console.Write("Cумма налога = {0} руб.", sum);
            Console.ReadKey();

        }
    }
}
