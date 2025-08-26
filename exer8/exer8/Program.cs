using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            y = 1;

            Console.WriteLine("Digite um número");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                y *= i;
                Console.WriteLine(i + "!= " + y);
            }
        }
    }
}