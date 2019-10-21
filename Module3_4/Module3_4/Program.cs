using System;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число, которое нужно записать наоборот");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n % 10);
            while ((n /= 10) != 0)
            Console.Write(n % 10);
            Console.ReadKey();
        }
   
    }
}
