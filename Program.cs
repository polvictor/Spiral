using System;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls input number of Raws: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls input number of Columns: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int[,] myArr = new int[R, C];
            int number = R * C;

            int x = 0;
            int y = 0;

            while (true)
            {
                for (int j = x; j < C - x; j++)  // moving right 
                {
                    myArr[y, j] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int i = y + 1; i < R - y; i++) // move down
                {
                    myArr[i, C - x - 1] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int j = C - x - 2; j >= 0 + x; j--) // move left
                {
                    myArr[R - y - 1, j] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                for (int i = R - y - 2; i >= 0 + y + 1; i--) // move up
                {
                    myArr[i, x] = number;
                    number--;
                }
                if (number == 0)
                {
                    break;
                }
                x++;
                y++;
            }
            Console.WriteLine("\nOur spiral: \n");
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (myArr[i, j] >= 10)
                    {
                        Console.Write(myArr[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(myArr[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
