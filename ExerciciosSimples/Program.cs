using System;

namespace ExerciciosSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um retângulo com largura 10 e altura 5
            Retangulo retangulo = new Retangulo(10, 5);
            retangulo.ExibirDimensoes();

            Console.WriteLine();
            Console.WriteLine($"Área: {retangulo.CalcularArea():F2}");

            Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro():F2}");
        }
    }
}