using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("salario");

            Console.WriteLine("Digite seu salario");
            float sal = float.Parse(Console.ReadLine());

            if(sal <yuuu 990){
                float media = (sal*30)/100;
                float final = (sal+media);

                Console.WriteLine($"Seu salario foi reajustado para R${final}");

            }

            else{
                Console.WriteLine("seu salario não sera reajustado");
            }

            // else(media > 10){
            //     Console.WriteLine("Por favor insira apenas notas de 0 a 10 !!");
            // }

        }
    }
}
