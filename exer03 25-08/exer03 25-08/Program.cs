using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r;

            Console.WriteLine("Digite um número:");
            n =int.Parse(Console.ReadLine());

            Console.WriteLine("Aqui está a tabuada dele.");

            for (int x = 0; x <= 10; x++)
            {
                r = n * x;
                Console.WriteLine(x + " x " + n + " = " + r);
            }
            Console.ReadKey();
        }
    }
}