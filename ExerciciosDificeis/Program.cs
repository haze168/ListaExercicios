using System;

namespace ExerciciosDificeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria três cartões diferentes
            Cartao cartao1 = new Cartao("1111-1111-1111-1111", "12/2028");
            Cartao cartao2 = new Cartao("2222-2222-2222-2222", "06/2029");
            Cartao cartao3 = new Cartao("3333-3333-3333-3333", "10/2030");

            // Cria três contas diferentes
            Conta conta1 = new Conta("Felipe", "001", 1000, cartao1);
            Conta conta2 = new Conta("João", "002", 2000, cartao2);
            Conta conta3 = new Conta("Maria", "003", 3000, cartao3);

            // Realiza operações na primeira conta
            conta1.Depositar(500);
            conta1.Sacar(200);
            conta1.Depositar(300);

            // Realiza operações na segunda conta
            conta2.Depositar(1000);
            conta2.Sacar(400);
            conta2.Sacar(100);

            // Realiza operações na terceira conta
            conta3.Depositar(700);
            conta3.Sacar(500);
            conta3.Depositar(200);

            // Exibe o relatório inicial das três contas
            Console.WriteLine("--- RELATÓRIO DAS CONTAS ---");
            Console.WriteLine();

            ExibirRelatorio(conta1);
            ExibirRelatorio(conta2);
            ExibirRelatorio(conta3);

            // Solicita os dados do cartão para realizar um saque
            Console.WriteLine("--- SAQUE COM CARTÃO ---");
            Console.Write("Número do cartão: ");
            string numeroCartao = Console.ReadLine();

            Console.Write("Validade do cartão: ");
            string validade = Console.ReadLine();

            Console.Write("Valor do saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());

            // Tenta realizar o saque em cada conta
            bool saqueRealizado = false;

            if (conta1.SacarComCartao(numeroCartao, validade, valorSaque))
            {
                saqueRealizado = true;
            }
            else if (conta2.SacarComCartao(numeroCartao, validade, valorSaque))
            {
                saqueRealizado = true;
            }
            else if (conta3.SacarComCartao(numeroCartao, validade, valorSaque))
            {
                saqueRealizado = true;
            }

            if (saqueRealizado)
            {
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Cartão inválido ou saldo insuficiente.");
            }

            Console.WriteLine();

            // Exibe o relatório final das três contas
            Console.WriteLine("--- RELATÓRIO FINAL ---");
            Console.WriteLine();

            ExibirRelatorio(conta1);
            ExibirRelatorio(conta2);
            ExibirRelatorio(conta3);
        }

        // Exibe o número, titular, saldo e extrato de uma conta
        static void ExibirRelatorio(Conta conta)
        {
            Console.WriteLine($"Número: {conta.ObterNumero()}");
            Console.WriteLine($"Titular: {conta.ObterNomeCliente()}");
            Console.WriteLine($"Saldo: R$ {conta.ObterSaldo():F2}");
            Console.WriteLine("Extrato:");
            conta.ExibirExtrato();
            Console.WriteLine();
        }
    }
}