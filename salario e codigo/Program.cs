using System;

namespace salario_e_codigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Salario 2.0");

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite seu salario {nome}");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo");
            string codigo = (Console.ReadLine());

            // Console.WriteLine("Digite o numero do calculo que deseja fazer?");

            // Console.WriteLine("---------------");
            // Console.WriteLine("(1) - Soma de 2 Numeros");
            // Console.WriteLine("(2) - Subtração do primeiro pelo segundo");
            // Console.WriteLine("(3) - Subtração do segundo pelo primeiro");
            // Console.WriteLine("(4) - Multiplicação dos dois numeros");
            // Console.WriteLine("(5) - Divisão do primeiro pelo segundo");
            // Console.WriteLine("(6) - Divisão do segundo pelo primeiro");
            // Console.WriteLine("---------------");

            switch(codigo){
                case "1": 
                float vfinal1 = ((salario*50)/100)+salario; 
                Console.WriteLine($"{nome}, salario atual R${salario}, codigo{codigo}, cargo Escriturário, percentual de aumento de 50%, reajuste de salario para R${vfinal1}");
                break;

                case "2": 
                float vfinal2 = ((salario*35)/100)+salario; 
                Console.WriteLine($"{nome}, salario atual R${salario}, codigo{codigo}, cargo Secretário, percentual de aumento de 35%, reajuste de salario para R${vfinal2}");
                break;

                case "3": 
                float vfinal3 = ((salario*20)/100)+salario; 
                Console.WriteLine($"{nome}, salario atual R${salario}, codigo{codigo}, cargo caixa, percentual de aumento de 20%, reajuste de salario para R${vfinal3}");
                break;

                case "4": 
                float vfinal4 = ((salario*10)/100)+salario; 
                Console.WriteLine($"{nome}, salario atual R${salario}, codigo{codigo}, cargo Gerente, percentual de aumento de 10%, reajuste de salario para R${vfinal4}");
                break;

                case "5": 
                float vfinal5 = salario;
                Console.WriteLine($"{nome}, salario atual R${salario}, codigo{codigo}, cargo Diretor, Não recebe aumento, reajuste de salario para R${vfinal5}");
                break;
        
            }
        }
    }
}
