using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca
{
    public class SeletorDeDificuldade
    {
        public string dificuldade { get; private set; }
        public int MaxErros { get; private set; }
        CapturadorDeEntradaUsuario capturaEntradaUsuario;
        
        public SeletorDeDificuldade()
        {
            dificuldade = "Facil";
            MaxErros = 6;
            capturaEntradaUsuario = new CapturadorDeEntradaUsuario();
            EscolherDificuldade();
        }

        public void EscolherDificuldade()
        {
            bool escolheu = false;
            while (!escolheu)
            {
                Console.Clear();
                Console.WriteLine("*** Jogo da Forca ***\n");
                Console.WriteLine("Escolha a Dificuldade Desejada:\n");
                Console.WriteLine("1 - Nivel Facil (6 tentativas + Dicas + Nome da Categoria)");
                Console.WriteLine("2 - Nivel Medio (4 tentativas + Nome da Categoria)");
                Console.WriteLine("3 - Nivel Dificil (4 tentativas, sem dicas e sem categoria!");
                Console.Write("\nDigite uma Opcao: ");
                string escolha = capturaEntradaUsuario.CapturaString();

                switch (escolha)
                {
                    case "1": dificuldade = "Facil";
                        MaxErros = 6;
                        break;
                    case "2": dificuldade = "Medio";
                        MaxErros = 4;
                        break;
                    case "3": dificuldade = "Dificil";
                        MaxErros = 4;
                        break;
                    default:
                        Console.Write("\nOpcao Invalida!");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                if(escolha == "1" || escolha == "2" || escolha == "3")
                {
                    escolheu = true;
                }
            }
        }

    }
}