﻿using System;

namespace Do_while_e_aray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do while com array!");

            string[] nomes = new string[3];
            int contador = 0;

            while(contador <3){

                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();
                contador++;

            }

            contador = 0;

            while(contador<3){
                Console.WriteLine($"O nome na posição{contador} é {nomes [contador]}");
                contador++;
            }
            

        }
    }
}
