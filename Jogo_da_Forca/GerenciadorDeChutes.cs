using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class GerenciadorDeChutes
    {
        public List<string> chutes {  get; private set; }
        CapturadorDeEntradaUsuario capturaEntradaUsuario;

        public GerenciadorDeChutes(CapturadorDeEntradaUsuario CapturaEntradaUsuario)
        {
            chutes = new List<string>();
            GerarListaChutes();
            capturaEntradaUsuario = CapturaEntradaUsuario;
        }
        public void GerarListaChutes()
        {
            chutes = new List<string>();
        }
        public void CapturarChute()
        {
            while (true)
            {
                Console.Write("\n\nDigite Seu Chute: ");
                string chute = capturaEntradaUsuario.CapturaString();
                if(!chutes.Contains(chute))
                {
                    chutes.Add(chute);
                    break;
                }
                else
                {
                    Console.WriteLine($"Voce Ja Chutou a Letra {chute}!");
                }
            }
        }
    }
}
