using System;

namespace PedraPapelTesoura
{
    public class Program
    {
        /*
         Regras:
         [1]Pedra   ganha de [3]Tesoura
         [2]Papel   ganha de [1]Pedra
         [3]Tesoura ganha de [2]Papel
         */

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

            ExibirResultado(jogada1, jogada2, resultado);

            ExibirFimDeJogo();
        }

        // Algoritmo principal
        public static int CalcularJogada(int jogada1, int jogada2)
        {
            if (jogada1 % 3 + 1 == jogada2)
                return jogada2;

            else if (jogada2 % 3 + 1 == jogada1)
                return jogada1;

            else
                return 0;    
        }        
                
        private static void ExibirResultado(int jogada1, int jogada2, int resultado)
        {
            var mensagem = string.Empty;

            if (resultado == jogada1)
                mensagem = "Jogador 1 ganhou!";

            else if (resultado == jogada2)
                mensagem = "Jogador 2 ganhou!";

            else
                mensagem = "Empate";

            Console.WriteLine();
            Console.WriteLine($"Resultado: {mensagem}");
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

        private static void ExibirFimDeJogo()
        {
            Console.WriteLine();
            Console.WriteLine("Fim de jogo! Pressione qualquer tecla para jogar novamente ou 0 para sair.");

            var opcao = Console.ReadKey();

            if (opcao.Key == ConsoleKey.NumPad0 || opcao.Key == ConsoleKey.D0)
                Environment.Exit(0);

            else
                JogarNovamente();
        }

        private static void JogarNovamente()
        {
            Console.Clear();
            NovoJogo();
        }
    }
}
