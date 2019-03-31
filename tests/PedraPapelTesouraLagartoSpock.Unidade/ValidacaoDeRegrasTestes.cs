using PedraPapelTesouraLagartoSpock.Unidade.Core;
using Xunit;

namespace PedraPapelTesouraLagartoSpock.Unidade
{
    public class ValidacaoDeRegrasTestes
    {
        [Fact]
        public void RegrasDosTestesEProgramaDevemTerValoresIguais()
        {
            var regrasTeste = ExtensoesTestes.ObterRegrasTeste();
            var regrasPrograma = Program.ObterRegras();

            for (int i = 0; i < regrasPrograma.GetLength(0); i++)
            {
                for (int z = 0; z < regrasPrograma.GetLength(1); z++)
                {
                    Assert.Equal(regrasTeste[i, z], regrasPrograma[i, z]);
                }
            }
        }

        [Fact]
        public void RegrasDosTestesEProgramaDevemTerDimensoesIguais()
        {
            var regrasTeste = ExtensoesTestes.ObterRegrasTeste();
            var regrasPrograma = Program.ObterRegras();

            Assert.Equal(regrasTeste.Rank, regrasPrograma.Rank);
        }        
    }
}
