using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class SelecionadorMenuInicial
    {
        public string SelecionaOpcao(CapturadorDeEntradaUsuario capturaEntradaUsuario)
        {
            Console.WriteLine("\nDigite uma Opcao: ");
            string escolha = capturaEntradaUsuario.CapturaString();
            switch (escolha)
            {
                case "1":
                case "2":
                case "9":
                    return escolha;
                default:
                    return "Opcao Invalida";
            }
        }
    }
}
