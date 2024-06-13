// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool clicouNoBotao = true;
            char genero = 'F';
            // Tipos de Write
            Console.WriteLine("O Status do botão é: " + clicouNoBotao); 
            Console.WriteLine("O botão é : {0}", clicouNoBotao);
            Console.WriteLine($"O botao: {clicouNoBotao}");
            
            Console.WriteLine("Digite um valor");
            string valorLido = Console.ReadLine();
            Console.WriteLine("O valor lido foi {0}", valorLido);
            Console.WriteLine("Digite outro valor:");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor lido foi {0}", valor);

        }
    }
}