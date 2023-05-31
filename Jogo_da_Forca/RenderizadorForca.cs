using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class RenderizadorForca
    {
        SorteadorDePalavraECategoria sortearPalavraECategoria;
        SeletorDeDificuldade seletorDeDificuldade;
        GerenciadorDeChutes gerenciadorChutes;
        public RenderizadorForca(SorteadorDePalavraECategoria SortearPalavraECategoria, 
            SeletorDeDificuldade SeletorDeDificuldade, GerenciadorDeChutes GerenciadorChutes)
        {
            sortearPalavraECategoria = SortearPalavraECategoria;
            seletorDeDificuldade = SeletorDeDificuldade;
            gerenciadorChutes = GerenciadorChutes;
        }
        public void ImprimeNivelDificuldade()
        {
            switch (seletorDeDificuldade.dificuldade)
            {
                case "Facil":
                    Console.WriteLine($"Categoria: {sortearPalavraECategoria.NomeCategoria}");
                    Console.WriteLine($"Dica: {sortearPalavraECategoria.Dica}");
                    break;
                case "Medio":
                    Console.WriteLine($"Categoria: {sortearPalavraECategoria.NomeCategoria}");
                    break;
                case "Dificil":
                    Console.WriteLine("Nivel Dificil | Sem dicas e categoria");
                    break;
            }
        }
        public void ImprimeForca(int numeroErros)
        {
            if (seletorDeDificuldade.MaxErros == 6)
            {
                Console.WriteLine("  _______ ");
                Console.WriteLine(" |      | ");
                Console.WriteLine(numeroErros >= 1 ? " |      0 " : " | ");
                //Console.WriteLine(numeroErros == 2 ? " |      |" : " | ");
                //Console.WriteLine(numeroErros == 3 ? " |     /|" : " | ");
                Console.WriteLine(numeroErros >= 4 ? " |     /|\\" : numeroErros >= 3 ? " |     /|" : 
                    numeroErros == 2 ? " |      |" : " | ");
                //Console.WriteLine(numeroErros == 5 ? " |     / " : " | ");
                Console.WriteLine(numeroErros >= 6 ? " |     / \\" : numeroErros == 5? " |     / " : " | ");
                Console.WriteLine(" | ");
            }
            else
            {
                Console.WriteLine("  _______ ");
                Console.WriteLine(" |      | ");
                Console.WriteLine(numeroErros >= 1 ? " |      0 " : " | ");
                Console.Write(numeroErros >= 3 ? " |     /|\\\n" : numeroErros == 2 ? " |      |\n" : " |\n");
                Console.WriteLine(numeroErros >= 4 ? " |     / \\" : " | ");
                Console.WriteLine(" | ");
            }
        }
        public void imprimePalavraForca()
        {
            Console.Write(" | ");
            for (int i = 0; i < sortearPalavraECategoria.Palavra.Length; i++)
            {
                bool achou = false;
                foreach (string x in gerenciadorChutes.chutes)
                {
                    if (sortearPalavraECategoria.Palavra[i].ToString() == x || sortearPalavraECategoria.Palavra[i] == ' ')
                    {
                        Console.Write($"{sortearPalavraECategoria.Palavra[i]} ");
                        achou = true;
                        break;
                    }
                }
                if (!achou)
                {
                    Console.Write("_ ");
                }
            }
        }
        public void MensagemFimJogo(string resultado)
        {
            if (resultado == "ganhou")
            {
                Console.WriteLine("\n");
                Console.WriteLine("              .-=========-.");
                Console.WriteLine("              \'-=======-'/");
                Console.WriteLine("              _|   .=.   |_");
                Console.WriteLine("             ((|  {{1}}  |))");
                Console.WriteLine("              \\|   /|\\   |/");
                Console.WriteLine("               \\__ '`' __/");
                Console.WriteLine("                 _`) (`_");
                Console.WriteLine("               _/_______\\_");
                Console.WriteLine("              /___________\\");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("\nParabens, Voce Ganhou!");
            } 
            else if(resultado == "perdeu")
            {
                Console.WriteLine("\n");
                Console.WriteLine("    _______________");
                Console.WriteLine("   /               \\");
                Console.WriteLine("  /                 \\");
                Console.WriteLine("//                   \\/\\");
                Console.WriteLine("\\|   XXXX     XXXX   | /");
                Console.WriteLine(" |   XXXX     XXXX   |/");
                Console.WriteLine(" |   XXX       XXX   |");
                Console.WriteLine(" |                   |");
                Console.WriteLine(" \\__      XXX      __/");
                Console.WriteLine("   |\\     XXX     /|");
                Console.WriteLine("   | |           | |");
                Console.WriteLine("   | I I I I I I I |");
                Console.WriteLine("   |  I I I I I I  |");
                Console.WriteLine("   \\_             _/");
                Console.WriteLine("     \\_         _/");
                Console.WriteLine("       \\_______/");
                Console.WriteLine("\nQue Pena, Voce Perdeu!\n");
                Console.WriteLine($"A palavra era {sortearPalavraECategoria.Palavra}!");
            }
            
        }
        
    }
}
