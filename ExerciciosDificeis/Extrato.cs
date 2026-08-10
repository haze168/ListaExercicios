using System;

namespace ExerciciosDificeis
{
    internal class Extrato
    {
        private DateTime dataMovimentacao;
        private double valorMovimentado;

        public Extrato(DateTime dataMovimentacao, double valorMovimentado)
        {
            this.dataMovimentacao = dataMovimentacao;
            this.valorMovimentado = valorMovimentado;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Data: {dataMovimentacao:dd/MM/yyyy HH:mm} | " + $"Valor: R$ {valorMovimentado:F2}");
        }
    }
}