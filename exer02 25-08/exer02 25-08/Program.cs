using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 0;

            Console.WriteLine("Digite dois números para fazer a ordem decrecente (apenas de números impares) entre eles ");
            Console.WriteLine("Digite um número para o começo da ordem: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número para o final: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            while (x > y)
            {
                    if (x % 2 == 1) 
                    {
                        Console.WriteLine("{0}", x);
                    }
                x--;
            }
        }
    }
}