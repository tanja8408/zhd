using System;


namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество выводимых четных чисел=");
            int n = int.Parse(Console.ReadLine());
            int i = 0, k = 1;

            while (k <= n)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} ", i);
                    k++;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}


