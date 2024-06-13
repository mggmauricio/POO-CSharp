using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o primeiro número: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro número: ");
            float valor3 = float.Parse(Console.ReadLine());

            float soma = valor1 + valor2 + valor3;
            Console.WriteLine("A soma é: " + soma);
            float media = (valor1 + valor2 + valor3)/3;
            Console.WriteLine("A média é: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("O primeiro número é par: " + ((valor1%2)==0));
            Console.WriteLine("O segundo número é par: " + ((valor2%2)==0));
            Console.WriteLine("O terceiro número é par: " + ((valor3%2)==0));
        }
    }
}