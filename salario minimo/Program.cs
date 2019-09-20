using System;

namespace salario_minimo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o salario minimo");
            int sminimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de dependentes do funcionario");
            int dependentes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas extras trabalhadas");
            int hrsextra = int.Parse(Console.ReadLine());
            

            float horatrabalhada = sminimo/5;

            float salariomes = horas*horatrabalhada;

            float vdependentes = dependentes*64.00;

            float vhoraextra = 

        }
    }
}
