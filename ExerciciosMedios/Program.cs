using System;

namespace ExerciciosMedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lâmpada de 60 W e 127 V
            Lampada lampada = new Lampada(60, 127);

            Console.WriteLine("Informações iniciais:");
            lampada.ExibirInformacoes();
            Console.WriteLine();

            // Liga a lâmpada
            lampada.Ligar();
            Console.WriteLine("Informações após tentar ligar:");
            lampada.ExibirInformacoes();
            Console.WriteLine();

            // Altera a potência e a voltagem
            lampada.Potencia = 100;
            lampada.Voltagem = 220;
            Console.WriteLine("Informações após alterar potência e voltagem:");
            lampada.ExibirInformacoes();
            Console.WriteLine();

            // Desliga a lâmpada
            lampada.Desligar();
            Console.WriteLine("Informações após desligar:");
            lampada.ExibirInformacoes();
        }
    }
}