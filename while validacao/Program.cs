using System;

namespace while_validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nome;

            do{
                System.Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();
            }while(nome.Length <= 3);

            string senha;

            do{
                System.Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();
            }while();



        }
    }
}
