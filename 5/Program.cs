using System;

namespace x3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vezes 3 ");

            Console.WriteLine("Digite um numero");
            int n1 = int.Parse(Console.ReadLine());

            int x = n1*3;

            Console.WriteLine($"{x}");
        }
    }
}
