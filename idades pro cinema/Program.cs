using System;

namespace idades_pro_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("idadessss");

            Console.WriteLine("Bemm vindoo aoooo SENAIIIIII!");

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 60 && idade < 18 ){
                Console.WriteLine("Parabens voce tem direito a meia entrada");
            }
            else{
                Console.WriteLine("Voce nao tem direito a meia entrada");
            }
        }
    }
}
