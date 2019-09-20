using System;

namespace array_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de array!");
            string [] nomes = new string[5];
            string [] telefones = new string[5];
            string [] email = new string[5];

            int contador = 0;

            while(contador <5 ){
                System.Console.WriteLine("Digite seu nome");
                nomes[contador] = Console.ReadLine();

                System.Console.WriteLine("Digite seu Telefone");
                telefones[contador] = Console.ReadLine();

                System.Console.WriteLine("Digite seu email");
                email[contador] = Console.ReadLine();

                contador++;

            }

            int contador2 = 0;
            while(contador2 <= 4){
                System.Console.WriteLine($"O cliente numero {contador2+1} - nome: {nomes[contador2]}, - Tel: {telefones[contador2]}, - Email: {email[contador2]} ");
                contador2++;

            }

        }
    }
}
