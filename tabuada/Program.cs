using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadaaaaaaaa!");

            Console.WriteLine("Digite o numero da tabuada que deseja");
            int numero  = int.Parse(Console.ReadLine());

            int contador = 0;

            while (contador < 11)
            {
                int result = numero * contador;

                Console.WriteLine($"{numero} X {contador} = {result}");

                contador += 1;

            }

        }
    }
}
