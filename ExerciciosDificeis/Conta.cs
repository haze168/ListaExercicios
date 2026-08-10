using System;

namespace ExerciciosDificeis
{
    internal class Conta
    {
        private string nomeCliente;
        private string numeroConta;
        private double saldo;

        // Vetor que armazena até 1000 movimentações
        private Extrato[] extratos;

        // Quantidade de extratos atualmente armazenados
        private int quantidadeExtratos;

        private Cartao cartao;
        public Conta(string nomeCliente, string numeroConta, double saldoInicial, Cartao cartao)
        {
            this.nomeCliente = nomeCliente;
            this.numeroConta = numeroConta;
            this.saldo = saldoInicial;
            this.cartao = cartao;

            // Cria um vetor com 1000 posições para os extratos
            extratos = new Extrato[1000];

            // Nenhum extrato foi registrado de início
            quantidadeExtratos = 0;
        }

        // Realiza um depósito na conta
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser maior que zero.");
                return;
            }

            saldo += valor;

            // Registra o depósito no extrato
            AdicionarExtrato(valor);
        }

        // Realiza um saque na conta
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

            // O saque é registrado como valor negativo
            AdicionarExtrato(-valor);
        }

        // Realiza um saque utilizando o cartão
        public bool SacarComCartao(string numeroCartao, string validade, double valor)
        {
            // Verifica se o número do cartão está correto
            if (numeroCartao != cartao.ObterNumero())
            {
                return false;
            }

            // Verifica se a validade está correta
            if (validade != cartao.ObterValidade())
            {
                return false;
            }

            // Se o cartão for válido, realiza o saque
            if (valor <= 0 || valor > saldo)
            {
                return false;
            }

            saldo -= valor;

            // Registra o saque no extrato
            AdicionarExtrato(-valor);

            return true;
        }

        // Adiciona uma nova movimentação ao extrato
        private void AdicionarExtrato(double valor)
        {
            // Verifica se o vetor ainda possui espaço
            if (quantidadeExtratos >= extratos.Length)
            {
                Console.WriteLine("O limite de extratos foi atingido.");
                return;
            }

            extratos[quantidadeExtratos] = new Extrato(DateTime.Now, valor);
            quantidadeExtratos++;
        }

        // Retorna o saldo atual da conta
        public double ObterSaldo()
        {
            return saldo;
        }

        // Retorna o número da conta
        public string ObterNumero()
        {
            return numeroConta;
        }

        // Retorna o nome do titular da conta
        public string ObterNomeCliente()
        {
            return nomeCliente;
        }

        // Exibe o extrato completo da conta
        public void ExibirExtrato()
        {
            if (quantidadeExtratos == 0)
            {
                Console.WriteLine("Nenhuma movimentação registrada.");
                return;
            }

            for (int i = 0; i < quantidadeExtratos; i++)
            {
                extratos[i].ExibirInformacoes();
            }
        }
    }
}