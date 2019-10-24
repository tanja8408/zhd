using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваш возраст:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 18)
            {
                Console.WriteLine(n % 2 == 0 ? "Поздравляем с 18 летием" : "Не с чем поздравлять");
            }
            else
            {
                Console.WriteLine((n % 2 != 0) & (n > 13) ? "Поздравляем с переходом в старшую школу" : "Не с чем поздравлять");
            }
            Console.ReadKey();
        }
    }
}
