using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sua idade");

            int idade;

            Console.WriteLine("Digite sua Idade");
            idade = int.Parse(Console.ReadLine());


            int meses = idade*12;

            int dias = idade*365;

            int horas = dias*24;

            int minutos = horas*60; 

            int segundos = minutos*60;

            Console.WriteLine($" Voce ja viveu {meses} meses ou {dias} dias ou {horas} horas ou {minutos} minutos ou {segundos} segundos");
        }
    }
}
