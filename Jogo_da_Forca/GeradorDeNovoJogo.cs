using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class GeradorDeNovoJogo
    {
        private SorteadorDePalavraECategoria sortearPalavraECategoria;
        private RenderizadorForca renderizarForca;
        private SeletorDeDificuldade seletorDeDificuldade;
        private GerenciadorDeChutes gerenciadorChutes;
        private VerificadorAcertosErros verificaAcertosErros;
        private VerificadorGanhouPerdeu verificaGanhouPerdeu;
        public GeradorDeNovoJogo(SorteadorDePalavraECategoria SortearPalavraECategoria, RenderizadorForca RenderizarForca,
            SeletorDeDificuldade SeletorDeDificuldade, GerenciadorDeChutes GerenciadorChutes, 
            VerificadorAcertosErros VerificaAcertosErros, VerificadorGanhouPerdeu VerificaGanhouPerdeu)
        {
            sortearPalavraECategoria = SortearPalavraECategoria;
            renderizarForca = RenderizarForca;
            seletorDeDificuldade = SeletorDeDificuldade;
            gerenciadorChutes = GerenciadorChutes;
            verificaAcertosErros = VerificaAcertosErros;
            verificaGanhouPerdeu = VerificaGanhouPerdeu;
        }
        public void Jogar()
        {
            sortearPalavraECategoria.Sortear();
            gerenciadorChutes.GerarListaChutes();
            string GanhouOuPerdeu = "continue";
            while (GanhouOuPerdeu == "continue")
            {
                renderizarForca.ImprimeNivelDificuldade();
                renderizarForca.ImprimeForca(verificaAcertosErros.Erros);
                renderizarForca.imprimePalavraForca();
                gerenciadorChutes.CapturarChute();
                verificaAcertosErros.VerificaAcertos();
                verificaAcertosErros.VerificaErros();
                GanhouOuPerdeu = verificaGanhouPerdeu.GanhouOuPerdeu();
                Console.Clear();
            }
            renderizarForca.ImprimeNivelDificuldade();
            renderizarForca.ImprimeForca(verificaAcertosErros.Erros);
            renderizarForca.imprimePalavraForca();
            renderizarForca.MensagemFimJogo(GanhouOuPerdeu);
            Console.ReadKey();
            verificaAcertosErros.ZerarContadorErrosAcertos();
        }
    }
}