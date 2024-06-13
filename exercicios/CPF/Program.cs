using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Digite um cpf para verificar se o mesmo é válido");
          string cpf = Console.ReadLine();
          CPF c = new CPF(cpf);
          if (c.checkCPF()){
            Console.WriteLine("CPF válido");
          }
          else{
            Console.WriteLine("CPF inválido");
          }
        }
    }
}