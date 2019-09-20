using System;

namespace conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ano de nascimento");

            Console.WriteLine("Digite seu ano de nascimento");
            int ano = int.Parse(Console.ReadLine());

            int anoatual = DateTime.Now.Year;

            int idade = anoatual-ano;

            int semana = idade*52;

            Console.WriteLine($"Voce tem {idade} anos ou {semana} semanas de vida.");Calculo_de_estudo.Program
            




        }
    }
}
