using System;

namespace maiores_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monte sua quadrilha!");

            int[] idade = new int[10];

            int contador = 0;
            int maior = 0;
            int menor = 0;

            while(contador <10 ){
                Console.WriteLine($"Digite sua Idade da pessoa Nº{contador+1}");
                idade[contador] = int.Parse(Console.ReadLine());

                if(idade[contador] >= 18){
                    maior++;
                }
                else{
                    menor++;
                }

                contador++;

            }

            Console.WriteLine($"Para sua quadrilha temos {maior} pessoas q ja podem ser presas e {menor} que ainda vão pra fundação casa (FEBEM).");


        }
    }
}
