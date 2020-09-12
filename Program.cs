using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome...");
            string nomeUsuario = Console.ReadLine();
            Console.Write("Olá, ");
            Console.WriteLine(nomeUsuario);

        }
    }
}
