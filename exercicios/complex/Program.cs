using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
 // Criando instâncias de números complexos
            Complex c1 = new Complex(3, 4);
            Complex c2 = new Complex(1, 2);
            Complex c3 = new Complex(3, 4);

            // Exibindo os números complexos originais
            Console.WriteLine($"Número complexo 1: {c1}");
            Console.WriteLine($"Número complexo 2: {c2}");
            Console.WriteLine($"Número complexo 3: {c3}");

            // Somando c2 a c1
            c1.Sum(c2);
            Console.WriteLine($"Após soma de c2 a c1: {c1}");

            // Subtraindo c2 de c1
            c1.Sub(c2);
            Console.WriteLine($"Após subtração de c2 de c1: {c1}");

            // Verificando igualdade
            Console.WriteLine($"c1 é igual a c3? {c1.Equals(c3)}");

            // Modificando c1 para igualar a c3
            c1.Sub(new Complex(2, 2));
            Console.WriteLine($"c1 modificado: {c1}");
            Console.WriteLine($"c1 é igual a c3? {c1.Equals(c3)}");
        }

    }
}