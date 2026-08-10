using System;

namespace ExerciciosSimples
{
    internal class Circulo
    {
        private double raio;
        public Circulo(double raio)
        {
            // O raio de um círculo deve ser maior que zero
            if (raio <= 0)
            {
                throw new ArgumentException("O raio deve ser maior que zero.");
            }

            this.raio = raio;
        }

        // Calcula e retorna a área do círculo
        public double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        // Calcula e retorna o perímetro do círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Raio: {raio:F2}");
            Console.WriteLine($"Área: {CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro():F2}");
        }
    }
}