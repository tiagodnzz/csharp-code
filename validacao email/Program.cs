using System;

namespace validacao_email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string email;

            do{
                System.Console.WriteLine("Digite seu Email");
                email = Console.ReadLine();
            }while(!email.Contains("@") || !email.Contains("."));

            string senha;

            do{
                System.Console.WriteLine("Digite sua senha.");
                System.Console.WriteLine("*Obrigatorio uso de caracteres especias como '@' '#' '.' '$'.");
                senha = Console.ReadLine();
            }while(senha.Length <= 6 || !senha.Contains("@") && !senha.Contains(".") && !senha.Contains("#") && !senha.Contains("$") && !senha.Contains("*"));

        }
    }
}
