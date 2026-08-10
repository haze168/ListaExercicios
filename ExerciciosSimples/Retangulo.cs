using System;

namespace ExerciciosSimples
{
    internal class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            if (largura <= 0 || altura <= 0)
            {
                throw new ArgumentException("A largura e a altura devem ser maiores que zero.");
            }

            this.largura = largura;
            this.altura = altura;
        }

        // Calcula e retorna a área do retângulo
        public double CalcularArea()
        {
            return largura * altura;
        }

        // Calcula e retorna o perímetro do retângulo
        public double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }
        public void ExibirDimensoes()
        {
            Console.WriteLine($"Largura: {largura:F2}");
            Console.WriteLine($"Altura: {altura:F2}");
        }
    }
}