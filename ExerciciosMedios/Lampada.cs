using System;

namespace ExerciciosMedios
{
    internal class Lampada
    {
        private bool ligada;
        private bool queimada;
        private double potencia;
        private double voltagem;

        // Ler e alterar a potência da lâmpada
        public double Potencia
        {
            get { return potencia; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A potência deve ser maior que zero.");
                }

                potencia = value;
            }
        }

        // Ler e alterar a voltagem da lâmpada
        public double Voltagem
        {
            get { return voltagem; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A voltagem deve ser maior que zero.");
                }

                voltagem = value;
            }
        }

        // Construtor básico da lâmpada
        public Lampada(double potencia, double voltagem)
        {
            Potencia = potencia;
            Voltagem = voltagem;

            // A lâmpada começa desligada e funcionando
            ligada = false;
            queimada = false;
        }

        // Liga a lâmpada
        public void Ligar()
        {
            if (queimada)
            {
                Console.WriteLine("Erro, a lâmpada está queimada.");
                return;
            }

            // 15% de chance da lâmpada queimar ao ser ligada
            Random random = new Random();
            int numero = random.Next(1, 101);

            if (numero <= 15)
            {
                queimada = true;
                ligada = false;

                Console.WriteLine("A lâmpada queimou ao ser ligada.");
                return;
            }

            ligada = true;
        }

        // Desliga a lâmpada
        public void Desligar()
        {
            ligada = false;
        }

        // Retorna true se a lâmpada estiver ligada
        public bool EstaLigada()
        {
            return ligada;
        }

        // Retorna true se a lâmpada estiver queimada
        public bool EstaQueimada()
        {
            return queimada;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Estado: {(ligada ? "Ligada" : "Desligada")}");
            Console.WriteLine($"Potência: {potencia} W");
            Console.WriteLine($"Voltagem: {voltagem} V");
            Console.WriteLine($"Queimada: {(queimada ? "Sim" : "Não")}");
        }
    }
}