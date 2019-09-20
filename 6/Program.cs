using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Acrescimo ");

            Console.WriteLine("Digite o valor da mercadoria");
            int valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual");
            int per = int.Parse(Console.ReadLine());

            int por = (valor*per)/100;

            int result = valor+por;

            Console.WriteLine($"{result}");



        }
    }
}
