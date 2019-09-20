using System;

namespace Lista_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Lista de mercadoooo!");
            string [] produto = new string[6];

            int contador = 0;

            while(contador <6 ){
                System.Console.WriteLine($"Digite o nome do seu {contador+1}º Produtos");
                produto[contador] = Console.ReadLine();


                contador++;

            }



            int contador2 = 0;

            while(contador2 <= 5){
                
                System.Console.WriteLine($"Produto numero {contador2+1}º - {produto[contador2]}");
                contador2++;

            }
        }
    }
}
