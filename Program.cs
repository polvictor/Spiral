using System;

namespace Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls input number of stairs: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\nWe are drawing stairs with " + n + " steps.\n");
            DrawStairs(n);            

            static void DrawStairs(int step)
            {
                for(int i = 0; i < step; i++)
                {
                    int space = 2 * i;
                    for (int j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                    }
                        Console.WriteLine("***");
                    space = 2 * (i + 1);
                    for (int j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                    }
                        Console.WriteLine("*");                    
                }
            }
        }
    }
}
