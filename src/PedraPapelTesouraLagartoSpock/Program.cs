using System;

namespace PedraPapelTesouraLagartoSpock
{
    public class Program
    {
        /*
         Regras:
         [1]Pedra   ganha de [3]Tesoura e [4]Lagarto
         [2]Papel   ganha de [1]Pedra   e [5]Spock
         [3]Tesoura ganha de [2]Papel   e [4]Lagarto
         [4]Lagarto ganha de [5]Spock   e [2]Papel
         [5]Spock   ganha de [3]Tesoura e [1]Pedra
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
            Console.WriteLine("[ 4 ] Lagarto");
            Console.WriteLine("[ 5 ] Spock");
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
            var regras = ObterRegras();

            if (jogada1 == jogada2)
                return 0;                    

            for (int i = 0; i < regras.Rank; i++)
                if (regras[jogada1 - 1, i] == jogada2)
                    return jogada1;

            return jogada2;
        }

        public static int[,] ObterRegras()
        {
            return new int[,] { { 3, 4 }, { 1, 5 }, { 2, 4 }, { 5, 2 }, { 3, 1 } };
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
            var regras = ObterRegras();
            var resultado = default(int);
            var jogada = Console.ReadLine();

            if (jogada == "0")
                Environment.Exit(0);

            else if (!int.TryParse(jogada, out resultado) || (resultado < 1 || resultado > regras.GetLength(0)))
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
