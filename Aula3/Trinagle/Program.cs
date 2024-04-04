using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Triangle A = new Triangle();
          double AreaA = A.calculate_area();
          Console.WriteLine("A area do triangulo x é: " + AreaA);
          Triangle B = new Triangle();
          double AreaB = B.calculate_area();
          Console.WriteLine("A area do triangulo y é: " + AreaB);

        }
    }
}