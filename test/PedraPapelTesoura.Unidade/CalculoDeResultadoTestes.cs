using Xunit;

namespace PedraPapelTesoura.Unidade
{
    public class CalculoDeResultadoTestes
    {
        /*
        [ 1 ] Pedra
        [ 2 ] Papel
        [ 3 ] Tesoura
        */

        [Fact]
        public void JogadasIguaisResultamEmEmpate()
        {
            var jogadasPossiveis = new int[] { 1, 2, 3 };

            for (int i = 1; i <= jogadasPossiveis.Length; i++)
            {
                var resultado = Program.CalcularJogada(i, i);
                Assert.Equal("Empate", resultado);
            }
        }

        [Fact]
        public void J1Pedra_J2Tesoura_DeveGanharJ1()
        {
            var jogador1 = 1;
            var jogador2 = 3;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 1 ganhou!", resultado);
        }

        [Fact]
        public void J1Papel_J2Pedra_DeveGanharJ1()
        {
            var jogador1 = 2;
            var jogador2 = 1;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 1 ganhou!", resultado);
        }

        [Fact]
        public void J1Tesoura_J2Papel_DeveGanharJ1()
        {
            var jogador1 = 3;
            var jogador2 = 2;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 1 ganhou!", resultado);
        }

        [Fact]
        public void J2Pedra_J1Tesoura_DeveGanharJ2()
        {
            var jogador1 = 3;
            var jogador2 = 1;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 2 ganhou!", resultado);
        }

        [Fact]
        public void J2Papel_J1Pedra_DeveGanharJ2()
        {
            var jogador1 = 1;
            var jogador2 = 2;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 2 ganhou!", resultado);
        }

        [Fact]
        public void J2Tesoura_J1Papel_DeveGanharJ2()
        {
            var jogador1 = 2;
            var jogador2 = 3;

            var resultado = Program.CalcularJogada(jogador1, jogador2);

            Assert.Equal("Jogador 2 ganhou!", resultado);
        }
    }
}
