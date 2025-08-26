using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite abaixo dois números.");
            Console.WriteLine("Primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Este são os números impares que estão entre os digitados.");

            while (n2 > n1)
            {
                if (n1 % 2 == 1)
                    if (n1 % 2 == 1)
                    {
                        Console.WriteLine("{0}", n1);
                    }
                n1++;
            }
        }
    }
}
