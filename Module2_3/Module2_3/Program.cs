using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double result1;
            Console.WriteLine("введите первое число: x ");
            string v1 = Console.ReadLine().Replace('.', ',');
            while (!Double.TryParse(v1, out result1))
            {
                Console.WriteLine("введено невеное значение. введите первое число: x ");
                v1 = Console.ReadLine().Replace('.', ',');
                continue;
            }

            Double result2;
            Console.WriteLine("введите второе число: y");
            string v2 = Console.ReadLine().Replace('.', ',');
            while (!Double.TryParse(v2, out result2))
            {
                Console.WriteLine("введено невеное значение. введите второе число: y");
                v2 = Console.ReadLine().Replace('.', ',');
                continue;
            }
            double z = result1;
            result1 = result2;
            result2 = z;
            {
                Console.WriteLine("Результат : x={0} и y={1}", result1, result2);
            }
            Console.Read();
        }
    }
}
