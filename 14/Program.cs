using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categorias Idade!");

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 7){
                Console.WriteLine("Sua categoria é infantil A");
            }
            else if(idade >= 8 && idade <= 10){
                Console.WriteLine("Sua categoria é infantil B");
            }
            else if(idade >= 11 && idade <= 13){
                Console.WriteLine("Sua categoria é juvenil A");
            }
            else if(idade >= 14 && idade <= 17){
                Console.WriteLine("Sua categoria é juvenil B");
            }
            else{
                Console.WriteLine("Sua categoria é Adulto");
            }


        }
    }
}
