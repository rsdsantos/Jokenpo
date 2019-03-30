using System;

namespace PedraPapelTesoura
{
    public class Program
    {
        static void Main(string[] args)
        {
            NovoJogo();
        }

        private static void NovoJogo()
        {
            Console.WriteLine("Escolha uma das seguintes opções:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("[ 1 ] Pedra");
            Console.WriteLine("[ 2 ] Papel");
            Console.WriteLine("[ 3 ] Tesoura");
            Console.WriteLine("[ 0 ] Sair do jogo");
            Console.WriteLine("----------------------------------------------");

            Console.Write("Jogador 1: ");            
            var jogada1 = ValidarJogada();

            Console.Write("Jogador 2: ");
            var jogada2 = ValidarJogada();            

            var resultado = CalcularJogada(jogada1, jogada2);

            ExibirResultado(resultado);
            ExibirFimDeJogo();
        }

        public static string CalcularJogada(int jogada1, int jogada2)
        {
            if (jogada1 % 3 + 1 == jogada2)
                return "Jogador 2 ganhou!";

            else if (jogada2 % 3 + 1 == jogada1)
                return "Jogador 1 ganhou!";

            else
                return "Empate";    
        }

        private static int ValidarJogada()
        {
            var resultado = 0;
            var jogada = Console.ReadLine();

            if (jogada == "0")
                Environment.Exit(0);

            else if (!int.TryParse(jogada, out resultado) || (resultado < 1 || resultado > 3))
            {
                JogadaInvalida();
                NovoJogo();
            }

            return resultado;
        }
        private static void JogadaInvalida()
        {
            Console.WriteLine("Jogada inválida. Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void ExibirResultado(string resultado)
        {
            Console.WriteLine();
            Console.WriteLine($"Resultado: {resultado}");
        }
        private static void ExibirFimDeJogo()
        {
            Console.WriteLine();
            Console.WriteLine("Fim de jogo! Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
