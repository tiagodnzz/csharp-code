using System;

namespace Calculo_de_estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de 2 Numeros");

            int n1;
            int n2;
            int n3;

            Console.WriteLine("Digite o prmeiro nota");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo nota");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro nota");
            n3 = int.Parse(Console.ReadLine());

            float result = (n1+n2+n3);
            float media = result/3;

            Console.WriteLine($"Sua média foi de: {result}");
        }
    }
}
