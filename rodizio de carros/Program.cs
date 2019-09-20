using System;

namespace rodizio_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio de Carros");

            Console.WriteLine("Digite o ultimo numero da placa do carro");
            int digito = int.Parse(Console.ReadLine());

            if(digito >= 0 && digito <= 1 ){
                Console.WriteLine("O dia do seu rodidzio de seu carro é Segunda-feira");
            }

            else if(digito >= 2 && digito <= 3 ){
                Console.WriteLine("O dia do seu rodidzio de seu carro é Terça-feira");
            }

            else if(digito >= 4 && digito <=5 ){
                Console.WriteLine("O dia do seu rodidzio de seu carro é Quarta-feira");
            }

            else if(digito >= 6 && digito <=7 ){
                Console.WriteLine("O dia do seu rodidzio de seu carro é Quinta-feira");
            }
            else if(digito >= 8 && digito <=9 ){
                Console.WriteLine("O dia do seu rodidzio de seu carro é Sexta-feira");
            }

        }
    }
}
