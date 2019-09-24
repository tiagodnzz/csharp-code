using System;

namespace sala_com_media
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nota1 = new int[2];
            int[] nota1 = new int[2];
            double[] media = new int [2];
            int[] aprovados = new int [2];
            int reprovados = new int [2];
            int contador = 0;
            int aprovados = 0;
            int reprovados = 0;

            do
            {
                System.Console.WriteLine($"{contador+1}º Aluno");
                System.Console.WriteLine($"Digite a 1ª nota:");
                nota1[contador] = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Digite a 2ª nota:");
                nota2[contador] = int.Parse(Console.ReadLine());

                media[contador] = (nota1[contador]+nota2[contador])/2;

                if(media[contador] >= 7){
                    aprovados++;
                }
                else{
                    reprovados++;
                }

                contador++;
            }
            while(contador < 2);
            
            int contadorb = 0;

            double somamedia = 0;

            while (contadorb < 2){
                somamedia = somamedia + media[contadorb];
                contador++;
            }

            System.Console.WriteLine($"A media da sala é {somamedia/2} temos {aprovados} Aprovados e {reprovados}");
        }
    }
}
