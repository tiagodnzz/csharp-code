using System;

namespace tabuada_com_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada com laço for!");

            Console.WriteLine("Qual tabuada deseja fazer?");
            float tabuada = float.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                System.Console.WriteLine($"{tabuada} X {i} = {tabuada*i}");
                
            }
        }
    }
}
