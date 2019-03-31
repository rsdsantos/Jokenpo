using PedraPapelTesouraLagartoSpock.Unidade.Core;
using Xunit;

namespace PedraPapelTesouraLagartoSpock.Unidade
{
    public class CalculoDeJogadaTestes
    {     
        [Fact]
        public void JogadasIguaisResultamEmEmpate()
        {
            var jogadasPossiveis = ExtensoesTestes.ObterRegrasTeste();

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
        public void PedraVSLagarto_PedraDeveVencer()
        {
            var jogada1 = 1;
            var jogada2 = 4;

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
        public void PapelVSSpock_PapelDeveVencer()
        {
            var jogada1 = 2;
            var jogada2 = 5;

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

        [Fact]
        public void TesouraVSLagarto_TesouraDeveVencer()
        {
            var jogada1 = 3;
            var jogada2 = 4;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void LagartoVSSpock_LagartoDeveVencer()
        {
            var jogada1 = 4;
            var jogada2 = 5;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(4, resultado);
        }

        [Fact]
        public void LagartoVSPapel_LagartoDeveVencer()
        {
            var jogada1 = 4;
            var jogada2 = 2;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(4, resultado);
        }

        [Fact]
        public void SpockVSTesoura_SpockDeveVencer()
        {
            var jogada1 = 5;
            var jogada2 = 3;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(5, resultado);
        }

        [Fact]
        public void SpockVSPedra_SpockDeveVencer()
        {
            var jogada1 = 5;
            var jogada2 = 1;

            var resultado = Program.CalcularJogada(jogada1, jogada2);

            Assert.Equal(5, resultado);
        }        
    }
}
