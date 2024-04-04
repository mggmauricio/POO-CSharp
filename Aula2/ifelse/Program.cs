using System;
using System.Globalization;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // IF ElSE IF E
          Console.WriteLine("Que horas são?");
          int hora = int.Parse(Console.ReadLine());

          if (hora < 12)
          {
              Console.WriteLine("Bom dia!");
          }
          else if (hora < 18)
          {
              Console.WriteLine("Boa tarde!");
          }
          else if (hora < 24)
          {
              Console.WriteLine("Boa noite!");
          }
          else
          {
            Console.WriteLine("Hora inválida!");
          }
          // Operador ternario:
          int num = 2;
          Console.WriteLine(num%2 == 0 ? "Par" : "Impar");

        }
    }
}