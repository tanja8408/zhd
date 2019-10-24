using System;

namespace cyber1
{
    class Program
    {

        static void Main()
        {
            Console.Write(" n = ");
            int N = int.Parse(Console.ReadLine());//границы снизу и сверху
            int[,] MM = new int[N, N];
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;

            for (int i = 0; i < MM.Length; i++)
            {
                MM[row, col] = i + 1;

                if (--gran == 0)
                {
                    gran = N * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }

                col += dy;
                row += dx;
            }

            for (int i = 0; i < MM.GetLength(0); i++)
            {
                for (int j = 0; j < MM.GetLength(0); j++)
                {
                    Console.Write(MM[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}