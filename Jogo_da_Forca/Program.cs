//menu interativo para o usuario
using Jogo_da_Forca;
using Jogo_da_Forca.Categorias;

SeletorDeDificuldade seletorDeDificuldade = new SeletorDeDificuldade();
CapturadorDeEntradaUsuario capturaEntradaUsuario = new CapturadorDeEntradaUsuario();
SelecionadorMenuInicial selecaoMenuInicial = new SelecionadorMenuInicial();
GerenciarCategorias gerenciadorCategorias = new GerenciarCategorias();
SorteadorDePalavraECategoria sortearPalavraECategoria = new SorteadorDePalavraECategoria(gerenciadorCategorias);
GerenciadorDeChutes gerenciadorChutes = new GerenciadorDeChutes(capturaEntradaUsuario);
RenderizadorForca renderizarForca = new RenderizadorForca(sortearPalavraECategoria, seletorDeDificuldade, gerenciadorChutes);
VerificadorAcertosErros verificaAcertosErros = new VerificadorAcertosErros(gerenciadorChutes, sortearPalavraECategoria);
VerificadorGanhouPerdeu verificaGanhouPerdeu = new VerificadorGanhouPerdeu(verificaAcertosErros, sortearPalavraECategoria, 
    seletorDeDificuldade);
GeradorDeNovoJogo novoJogo = new GeradorDeNovoJogo(sortearPalavraECategoria, renderizarForca, seletorDeDificuldade, gerenciadorChutes, 
    verificaAcertosErros, verificaGanhouPerdeu);


while (true)
{
    Console.WriteLine("*** Jogo da Forca ***\n");
    Console.WriteLine($"1 - Jogar o Jogo da Forca - Nivel {seletorDeDificuldade.dificuldade}");
    Console.WriteLine("2 - Escolher Dificuldade");
    Console.WriteLine("9 - Fechar o Programa");
    switch (selecaoMenuInicial.SelecionaOpcao(capturaEntradaUsuario))
    {
        case "1":
            Console.Clear();
            novoJogo.Jogar();
            break;
        case "2":
            seletorDeDificuldade.EscolherDificuldade();
            break;
        case "9":
            Console.WriteLine("Encerrando o Programa...");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opcao Invalida, digite uma das opcoes do menu!");
            Console.ReadLine();
            break;
    }
    Console.Clear();
}