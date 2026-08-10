using System;

namespace ExerciciosSimples
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string genero;
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Gênero: {genero}");
        }
        public bool EhMaiorDeIdade()
        {
            return idade >= 18;
        }
    }
}