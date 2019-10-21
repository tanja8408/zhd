using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру, которую нужно убрать:");
            int d = int.Parse(Console.ReadLine());
            int res = 0;
            int pow = 1;

            while (n != 0)
            {
                var temp = n % 10;
                n /= 10;
                if (temp == d) continue;
                res += temp * pow;
                pow *= 10;
            }
            
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
