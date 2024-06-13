using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe Invoice
            Invoice invoice = new Invoice(101, "Mouse óptico", 5, 29.99);

            // Exibindo as informações da fatura
            Console.WriteLine(invoice.ToString());

            // Modificando os valores da fatura
            invoice.Qt = -3; // Isso deve ser ajustado para 0
            invoice.Price = -50.0; // Isso deve ser ajustado para 0.0

            // Exibindo as informações da fatura após modificação
            Console.WriteLine("\nApós modificação:");
            Console.WriteLine(invoice.ToString());
        }

    }
}