using System;

namespace caastro_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] produtonome = new string[3];
            double[] produtospreco = new double[3];

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtonome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço");
                produtospreco[i] = double.Parse(Console.ReadLine());
            }


            
            // foreach (var item in produtonome)
            // {
            //     System.Console.WriteLine($"Produto: {item}");
            // }

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"Produto : {produtonome[i]}, Preço: {produtospreco[i]}");
            }
        }
    }
}
