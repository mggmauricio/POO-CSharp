﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operadores Aritméticos");
            // Atribuidores aritméticos
            int n1 = 3 + 4 * 2;
            int n2 = (3+4) * 2;
            int n3 = 17 / 3;
            int n4 = 17 % 3;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            double n5 = Math.Pow(2, 3);
            Console.WriteLine(n5);
            // Operadores de atribuição
            n5 += 10;
            Console.WriteLine(n5);
            n5 -= 10;
            Console.WriteLine(n5);
            n5 *= 10;
            Console.WriteLine(n5);
            n5 /= 10;
            Console.WriteLine(n5);
            n5 %= 10;
            //Operadores prefix e sufix ++v --v v++
            string a = "ABC";
            int x = 0;
            Console.WriteLine(a[x++]); //X vale 0 ainda, ou seja vai printar "A" e depois soma +1
            Console.WriteLine(a[++x]); //X vale 1 e soma mais 1 ou seja vai printar "C"
            
            
        }
    }
}