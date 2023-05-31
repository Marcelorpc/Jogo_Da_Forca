using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class VerificadorAcertosErros
    {
        GerenciadorDeChutes gerenciarChutes;
        public int Acertos { get; private set; }
        public int Erros { get; private set; }
        private SorteadorDePalavraECategoria sortearPalavraECategoria;
        public VerificadorAcertosErros(GerenciadorDeChutes GerenciarChutes, SorteadorDePalavraECategoria SortearPalavraECategoria)
        {
            gerenciarChutes = GerenciarChutes;
            sortearPalavraECategoria = SortearPalavraECategoria;
            Acertos = 0;
            Erros = 0;
        }
        public void VerificaAcertos()
        {
            Acertos = 0;

            for(int i = 0; i < sortearPalavraECategoria.Palavra.Length; i++)
            {
                foreach(string chute in gerenciarChutes.chutes)
                {
                    if (sortearPalavraECategoria.Palavra[i] == chute[0])
                    {
                        Acertos++;
                    }
                }
                if (sortearPalavraECategoria.Palavra[i] == ' ')
                {
                    Acertos++;
                }
            }
        }
        public void VerificaErros()
        {
            Erros = 0;
            foreach(string chute in gerenciarChutes.chutes)
            {
                if (!sortearPalavraECategoria.Palavra.Contains(chute))
                {
                    Erros++;
                }
            }
        }
        public void ZerarContadorErrosAcertos()
        {
            Erros = 0;
            Acertos = 0;
        }
    }
}
