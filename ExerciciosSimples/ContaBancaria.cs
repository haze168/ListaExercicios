using System;

namespace ExerciciosSimples
{
    internal class ContaBancaria
    {
        private string numeroConta;
        private string nomeTitular;
        private double saldo;
        public ContaBancaria(string numeroConta, string nomeTitular, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldo = saldoInicial;
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
                return;
            }

            saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser maior que zero.");
                return;
            }

            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }

            saldo -= valor;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Número da conta: {numeroConta}");
            Console.WriteLine($"Titular: {nomeTitular}");
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }
}