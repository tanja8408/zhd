using System;
namespace Module3_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            int result = 0;
            if (a < 0 && b < 0)
                
                for (int i = 0; i < -a; i++)
                {
                    result += -b;
                }
            
            else if (a > 0 && b > 0)
                
                for (int i = 0; i < a; i++)
                {
                    result += b;
                }

            else for (int i = 0; i < Math.Max(a, b); i++)
                {
                    result += Math.Min(a, b);
                }
            Console.WriteLine("Произведение чисел= ");
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}





