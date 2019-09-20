using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Impar ????");

            Console.WriteLine("Digite o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            float result1 = (n1 % 2);
            float result2 = (n2 % 2);

            // switch(result1 )

            if(result1 == 0 && result2 == 0){
                Console.WriteLine($"O numero {n1} é par e o {n2} tambem");
            }
            else if(result1 == 1 && result2 == 1){
                Console.WriteLine($"O numero {n1} é impar e o {n2} tambem");
            }

            else if(result1 == 1 && result2 == 0 ){
                Console.WriteLine($"O numero {n1} é impar e o {n2} é par");
            }
            else if(result1 == 0 && result2 == 1){
                Console.WriteLine($"O numero {n1} é par e o {n2} é impar");
            }

            if(n1 > n2){
                Console.WriteLine($"O numero {n1} é maior que {n2}");
            }
            else if(n2 > n1){
                Console.WriteLine($"O numero {n2} é maior que {n1}");
            }
            else if(n1 == n2){
                Console.WriteLine("Ambos numeros são iguais");
            }







        }
    }
}
