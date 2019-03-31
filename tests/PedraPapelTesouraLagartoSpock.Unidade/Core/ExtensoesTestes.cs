namespace PedraPapelTesouraLagartoSpock.Unidade.Core
{
    public class ExtensoesTestes
    {
        public static int[,] ObterRegrasTeste()
        {
            // As regras são replicadas para garantir que se houver mudanças no programa os testes sejam afetados.
            return new int[,] { { 3, 4 }, { 1, 5 }, { 2, 4 }, { 5, 2 }, { 3, 1 } };
        }
    }
}
