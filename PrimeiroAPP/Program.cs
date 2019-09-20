using System;

namespace PrimeiroAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            // Olha o main aqui olha

            // Console.WriteLine("Salveee rapeizeeee !!!!");

            Console.WriteLine("Soma de 2 Numeros");

            int n1;
            int n2;
            int result;

            Console.WriteLine("Digite o prmeiro numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());

            result = n1+n2;

            Console.WriteLine($"O resultado é: {result}");
   
        }
    }
}
