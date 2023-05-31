using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class CapturadorDeEntradaUsuario
    {
        public string CapturaString()
        {
            while (true)
            {
                string escolha = Console.ReadLine().ToString().ToLower();
                if (string.IsNullOrEmpty(escolha))
                {
                    Console.Write("\nEntrada Invalida! Tente Novamente: ");
                }
                else if (escolha.Length > 1)
                {
                    Console.Write("\nEntrada Invalida, Digite Apenas 1 Caractere! Tente Novamente: ");
                }
                else
                {
                    return escolha;
                }
            }
        }
    }
}
