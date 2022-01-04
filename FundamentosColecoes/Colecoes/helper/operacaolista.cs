using System.Collections.Generic;

namespace Colecoes.helper
{
    public class operacaolista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice {i}, valor {lista[i]}");
            }
        }
    }
}