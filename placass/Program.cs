using System;

namespace placass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Rodizio de Carros");

            Console.WriteLine("Digite o ultimo numero da placa do carro");
            string numero = Console.ReadLine();

            int caracteres = numero.Length;

            int digito = int.Parse(numero.Substring(caracteres - 1));



            if(digito == 0 || digito == 1 ){
                Console.WriteLine($"O dia do seu rodidzio de seu carro é Segunda-feira, digito final=  {digito}");
            }

            else if(digito == 2 || digito == 3 ){
                Console.WriteLine($"O dia do seu rodidzio de seu carro é Terça-feira, digito final= {digito}");
            }

            else if(digito == 4 || digito ==5 ){
                Console.WriteLine($"O dia do seu rodidzio de seu carro é Quarta-feira, digito final= {digito}");
            }

            else if(digito == 6 || digito ==7 ){
                Console.WriteLine($"O dia do seu rodidzio de seu carro é Quinta-feira, digito final={digito}");
            }
            else if(digito == 8 || digito ==9 ){
                Console.WriteLine($"O dia do seu rodidzio de seu carro é Sexta-feira {digito}");
            }
        }
    }
}
