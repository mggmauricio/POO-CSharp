using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Invoice
    {
        // Atributos da classe
        public int Cod { get; set; }
        public string Description { get; set; }

        private int _qt;
        private double _price;

        public int Qt
        {
            get
            {
                return _qt;
            }
            set
            {
                _qt = value >= 0 ? value : 0;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value >= 0 ? value : 0.0;
            }
        }

        // Construtor da classe
        public Invoice(int code, string description, int qt, double price)
        {
            Cod = code;
            Description = description;
            Qt = qt;
            Price = price;
        }

        // Método para calcular o valor da fatura
        public double GetInvoiceAmount()
        {
            return Qt * Price;
        }

        // Método ToString para retornar as informações da fatura
        public override string ToString()
        {
            return $"Código do Item: {Cod}\nDescrição: {Description}\nQuantidade: {Qt}\nPreço Unitário: {Price:C}\nValor Total: {GetInvoiceAmount():C}";
        }
    }
}


