using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, f;

            i = 11;
            f = 250;
            
            Console.WriteLine("Esses são os números pares entre 11 e 250");
            while (f >= i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                i++;
            }
        }
    }
}
