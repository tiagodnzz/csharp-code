using System;

namespace cargos_com_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cargos com switch!");

            Console.WriteLine("Digite o numero do cargo para descobrir o sálario");

            Console.WriteLine("---------------");
            Console.WriteLine("(1) - Diretor");
            Console.WriteLine("(2) - Gerente");
            Console.WriteLine("(3) - Professor");
            Console.WriteLine("(4) - Coordenador");
            Console.WriteLine("(5) - Atendente");
            Console.WriteLine("---------------");

            string resposta = Console.ReadLine();

            switch(resposta){
                case "1": Console.WriteLine("O salario do diretor é de R$18 mil reais");
                break;

                case "2": Console.WriteLine("O salario do gerente é de R$14 mil reais");
                break;

                case "3": Console.WriteLine("O salario do Professor é de R$8 mil reais");
                break;

                case "4": Console.WriteLine("O salario do Coordenador é de R$10 mil reais");
                break;

                case "5": Console.WriteLine("O salario do atendente é de R$3 mil reais");
                break;


                
            }

        }
    }
}
