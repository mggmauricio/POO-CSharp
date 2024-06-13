using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          // Operadores de comparação
            Console.WriteLine(10<9);
            Console.WriteLine(10>9);
            Console.WriteLine(10<=9);
            Console.WriteLine(10>=9);
            Console.WriteLine(10==9);
            Console.WriteLine(10!=9);
            Console.WriteLine(10==10);

            // Operadores lógicos
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);

            Console.WriteLine(!true);
            Console.WriteLine(!false);

            // Console.ReadLine();

        }
        
    }
}