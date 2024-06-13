using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    // Declaração da classe
    public class CPF
    {
        // Atributos da classe
        public string cpf;

        // Construtor da classe
        public CPF(string cpf)
        {
            this.cpf = cpf;
        }

        public bool checkCPF()
        {
            if (verify_first_digit(this.cpf) && verify_second_digit(this.cpf))
            {
                return true;
            }
            return false;
        }

        private bool verify_first_digit(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            int sum = 0;
            int multiplier = 10;
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * multiplier;
                multiplier--;
            }

            int rest = sum % 11;
            int first_digit = rest < 2 ? 0 : 11 - rest;
            return first_digit == int.Parse(cpf[9].ToString());
        }

        private bool verify_second_digit(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            int sum = 0;
            int multiplier = 11;
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(cpf[i].ToString()) * multiplier;
                multiplier--;
            }

            int rest = sum % 11;
            int second_digit = rest < 2 ? 0 : 11 - rest;
            return second_digit == int.Parse(cpf[10].ToString());
        }
    }
}

