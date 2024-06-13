using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Complex
    {
        // Propriedades para os números complexos
        public int Real { get; set; }
        public int Imag { get; set; }

        // Construtor que inicializa o número complexo com parte real e imaginária
        public Complex(int real, int imag)
        {
            this.Real = real;
            this.Imag = imag;
        }

        // Construtor que inicializa o número complexo apenas com a parte real
        public Complex(int real)
        {
            this.Real = real;
            this.Imag = 0;
        }

        // Método para somar um número complexo com a instância atual
        public void Sum(Complex complex)
        {
            this.Real += complex.Real;
            this.Imag += complex.Imag;
        }

        // Método para subtrair um número complexo da instância atual
        public void Sub(Complex complex)
        {
            this.Real -= complex.Real;
            this.Imag -= complex.Imag;
        }

        // Sobrescrita do método Equals para comparar dois números complexos
        public override bool Equals(object? obj)
        {
            if (obj is Complex other)
            {
                return this.Real == other.Real && this.Imag == other.Imag;
            }
            return false;
        }

        // Sobrescrita do método ToString para fornecer uma representação legível do número complexo
        public override string ToString()
        {
            return $"O número é: ({this.Real}, {this.Imag}i)";
        }
    }
}