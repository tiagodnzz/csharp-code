using System;

namespace laço_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço repetição de while!");


            int contador = int.Parse(Console.ReadLine())

            Console.WriteLine("Digite o valor limite");
            int limite = int.Parse(Console.ReadLine());

            while (contador <= limite){
                Console.WriteLine(contador);
                contador = contador + 1;
            }

        }
    }
}
