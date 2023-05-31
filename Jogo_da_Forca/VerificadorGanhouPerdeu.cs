using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class VerificadorGanhouPerdeu
    {
        private VerificadorAcertosErros verificaAcertosErros;
        private SorteadorDePalavraECategoria sortearPalavraECategoria;
        private SeletorDeDificuldade seletorDeDificuldade;
        public VerificadorGanhouPerdeu(VerificadorAcertosErros VerificaAcertosErros, 
            SorteadorDePalavraECategoria SortearPalavraECategoria, SeletorDeDificuldade SeletorDeDificuldade)
        {
            verificaAcertosErros = VerificaAcertosErros;
            sortearPalavraECategoria = SortearPalavraECategoria;
            seletorDeDificuldade = SeletorDeDificuldade;
        }
        public string GanhouOuPerdeu()
        {
            if(verificaAcertosErros.Acertos >= sortearPalavraECategoria.Palavra.Length)
            {
                return "ganhou";
            }
            else if(verificaAcertosErros.Erros >= seletorDeDificuldade.MaxErros)
            {
                return "perdeu";
            }
            else
            {
                return "continue";
            }
        }
    }
}
