using System;

namespace ExerciciosMedios
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private int anoPublicacao;
        private int numeroPaginas;
        private bool disponivel;

        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
            this.numeroPaginas = numeroPaginas;

            // Todo livro começa disponível para empréstimo
            disponivel = true;
        }

        // Empresta o livro se ele estiver disponível
        public void Emprestar()
        {
            if (disponivel)
            {
                disponivel = false;
                Console.WriteLine("Livro emprestado.");
            }
            else
            {
                Console.WriteLine("Erro, o livro já está emprestado.");
            }
        }

        // Devolve o livro se ele estiver emprestado
        public void Devolver()
        {
            if (!disponivel)
            {
                disponivel = true;
                Console.WriteLine("Livro devolvido.");
            }
            else
            {
                Console.WriteLine("O livro já está disponível.");
            }
        }

        // Retorna true se o livro estiver disponível para empréstimo
        public bool EstaDisponivel()
        {
            return disponivel;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Ano de publicação: {anoPublicacao}");
            Console.WriteLine($"Número de páginas: {numeroPaginas}");
            Console.WriteLine($"Disponível: {(disponivel ? "Sim" : "Não")}");
        }
    }
}