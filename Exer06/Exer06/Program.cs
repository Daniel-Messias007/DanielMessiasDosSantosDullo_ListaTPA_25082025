using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10; 
            float media;
            Console.WriteLine("Digite a nota de um aluno em 10 matérias.");
            Console.WriteLine("Nota 1:");
            n1 = int.Parse(Console.ReadLine());

           
                while (n1 > 10)
                {
                    Console.WriteLine("A nota não pode ser maior que 10.");
                    Console.WriteLine("Digite a nota 1 novamente:");
                    n1 = int.Parse(Console.ReadLine());
                

            }

            Console.WriteLine("Nota 2:");
            n2 = int.Parse(Console.ReadLine());
           
                while (n2 > 10)
                {
                    Console.WriteLine("A nota não pode ser maior que 10.");
                    Console.WriteLine("Digite a nota 2 novamente:");
                    n2 = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("Nota 3:");
            n3 = int.Parse(Console.ReadLine());

            while (n3 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 3 novamente:");
                n3 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 4:");
            n4 = int.Parse(Console.ReadLine());

            while (n4 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 4 novamente:");
                n4 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 5:");
            n5 = int.Parse(Console.ReadLine());

            while (n5 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 5 novamente:");
                n5 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 6:");
            n6 = int.Parse(Console.ReadLine());

            while (n6 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 6 novamente:");
                n6 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 7:");
            n7 = int.Parse(Console.ReadLine());

            while (n7 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 7 novamente:");
                n7 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 8:");
            n8 = int.Parse(Console.ReadLine());

            while (n8 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 8 novamente:");
                n8 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 9:");
            n9 = int.Parse(Console.ReadLine());

            while (n9 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 9 novamente:");
                n9 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nota 10:");
            n10 = int.Parse(Console.ReadLine());

            while (n10 > 10)
            {
                Console.WriteLine("A nota não pode ser maior que 10.");
                Console.WriteLine("Digite a nota 10 novamente:");
                n10 = int.Parse(Console.ReadLine());
            }

            media = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) / 10;
            Console.WriteLine("A média das notas é: " + media);

        }
    }
}
