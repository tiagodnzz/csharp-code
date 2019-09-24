using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] nome = new string[10];
            int[] idade = new int[10];
            float[] peso = new float[10];
            float[] altura = new float[10];
            string[] sexo = new string[10];
            double[] imc = new double[10];
            
            int homem = 0;
            int mulher = 0;
            int idadehomem = 0;
            int idademulher = 0;
            double mediahomens = 0;
            double mediamulher = 0;


            // string homens;
            // string mulheres;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome da pessoa Nº{i+1}");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Digite a idade da pessoa Nº{i+1}");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o peso da pessoa Nº{i+1}");
                peso[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a altura da pessoa Nº{i+1}");
                altura[i] = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o sexo da pessoa Nº{i+1}");
                Console.WriteLine("Obs: 'F' para feminino e 'M' para masculino");
                sexo[i] = Console.ReadLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (sexo[i] == "M")
                {
                    homem++;
                    idadehomem += idade[i];
                    
                }else{
                    mulher++;
                    idademulher += idade[i];
                    
                }
                
            }

            for (int i = 0; i < 10; i++)
            {
                imc[i] = peso[i]/(altura[i]*altura[i]);

                System.Console.WriteLine($" {nome[i]} seu IMC é de {imc[i]}");

            }

            System.Console.WriteLine($"O total de homens é {homem} e {mulher} mulheres");
            mediamulher = idademulher/mulher;
            mediahomens = idadehomem/homem;
            System.Console.WriteLine($"A media de homens é {mediahomens} e {mediamulher} mulheres");


            
        }
    }
}
