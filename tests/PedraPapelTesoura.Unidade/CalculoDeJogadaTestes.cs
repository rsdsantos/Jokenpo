using Xunit;

namespace PedraPapelTesoura.Unidade
{
    public class CalculoDeJogadaTestes
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
                Assert.Equal(0, resultado);
            }
        }

        [Fact]
        public void PedraVSTesoura_PedraDeveVencer()
        {
            var jogada1 = 1;
            var jogada2 = 3;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(1, resultado);
        }

        [Fact]
        public void PapelVSPedra_PapelDeveVencer()
        {
            var jogada1 = 2;
            var jogada2 = 1;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void TesouraVSPapel_TesouraDeveVencer()
        {
            var jogada1 = 3;
            var jogada2 = 2;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(3, resultado);
        }        
    }
}
