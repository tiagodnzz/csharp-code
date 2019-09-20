using System;

namespace medias
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Médiaaaassssss e notassssssssss!");

            Console.WriteLine("Bemm vindoo aoooo SENAIIIIII!");

            Console.WriteLine("Digite sua primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1+nota2)/2;

            if(media >= 50 && faltas <= 30){
                Console.WriteLine("Parabens não fez mais do que a obrigação");
            }
            else{
                Console.WriteLine("Voce foi reprovado seu inutil");
            }





        }
    }
}
