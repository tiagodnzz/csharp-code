using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Calculator!");

            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero do calculo que deseja fazer?");

            Console.WriteLine("---------------");
            Console.WriteLine("(1) - Soma de 2 Numeros");
            Console.WriteLine("(2) - Subtração do primeiro pelo segundo");
            Console.WriteLine("(3) - Subtração do segundo pelo primeiro");
            Console.WriteLine("(4) - Multiplicação dos dois numeros");
            Console.WriteLine("(5) - Divisão do primeiro pelo segundo");
            Console.WriteLine("(6) - Divisão do segundo pelo primeiro");
            Console.WriteLine("---------------");

            string resposta = Console.ReadLine();

            switch(resposta){
                case "1": 
                float r = n1 + n2;
                Console.WriteLine($"Voce escolheu soma de  numeros \n Sua resposta é {r} ");
                break;

                case "2": 
                float r1 = n1 - n2;
                Console.WriteLine($"Voce escolheu Subtração do primeiro pelo segundo \n Sua resposta é {r1} ");
                break;

                case "3": 
                float r2 = n2 - n1;
                Console.WriteLine($"Voce escolheu Subtração do segundo pelo primeiro \n Sua resposta é {r2} ");
                break;

                case "4": 
                float r3 = n1 * n2;
                Console.WriteLine($"Voce escolheu Multiplicação dos dois numeros \n Sua resposta é {r3} ");
                break;

                case "5": 
                float r4 = n1 / n2;
                Console.WriteLine($"Voce escolheu Divisão do primeiro pelo segundo \n Sua resposta é {r4} ");
                break;

                case "6": 
                float r5 = n2 / n1;
                Console.WriteLine($"Voce escolheu Divisão do segundo pelo primeiro \n Sua resposta é {r5} ");
                break;

            }
        }
    }
}
