using System;

namespace ExerciciosDificeis
{
    internal class Cartao
    {
        private string numero;
        private string validade;

        public Cartao(string numero, string validade)
        {
            this.numero = numero;
            this.validade = validade;
        }

        public string ObterNumero()
        {
            return numero;
        }

        public string ObterValidade()
        {
            return validade;
        }
    }
}