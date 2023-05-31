using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Categorias
{
    public class Filmes
    {
        public Dictionary<string, string> _palavras_e_dicas;
        public string Categoria = "Filmes";

        public Filmes()
        {
            _palavras_e_dicas = new Dictionary<string, string>();
            adicionarPalavras();
        }

        private void adicionarPalavras()
        {
            _palavras_e_dicas.Add("avatar", "Filme de ficção científica dirigido por James Cameron, que se passa em um planeta alienígena chamado Pandora.");
            _palavras_e_dicas.Add("titanic", "Romance dramático dirigido por James Cameron, que retrata o trágico naufrágio do RMS Titanic.");
            _palavras_e_dicas.Add("senhor dos aneis", "Trilogia baseada na obra literária de J.R.R. Tolkien, que narra a jornada épica de um grupo de heróis em um mundo de fantasia.");
            _palavras_e_dicas.Add("star wars", "Saga espacial criada por George Lucas, que apresenta uma galáxia com batalhas entre o lado luminoso e o lado sombrio da Força.");
            _palavras_e_dicas.Add("harry potter", "Série de filmes baseada nos livros de J.K. Rowling, que segue as aventuras do jovem bruxo Harry Potter e seus amigos em Hogwarts.");
            _palavras_e_dicas.Add("jurassic park", "Filme de ficção científica dirigido por Steven Spielberg, que apresenta um parque temático habitado por dinossauros.");
            _palavras_e_dicas.Add("matrix", "Filme de ficção científica dirigido pelos irmãos Wachowski, que explora uma realidade simulada em um futuro distópico.");
            _palavras_e_dicas.Add("o rei leao", "Animação da Disney que conta a história de Simba, um jovem leão que enfrenta desafios para assumir seu lugar como rei da savana.");
            _palavras_e_dicas.Add("interestelar", "Filme de ficção científica dirigido por Christopher Nolan, que aborda viagens espaciais em busca de um novo lar para a humanidade.");
            _palavras_e_dicas.Add("o poderoso chefao", "Trilogia de filmes que retrata a vida da família Corleone no crime organizado.");
            _palavras_e_dicas.Add("o labirinto do fauno", "Filme de fantasia dirigido por Guillermo del Toro, que mescla realidade e mundo imaginário durante a Guerra Civil Espanhola.");
            _palavras_e_dicas.Add("pulp fiction", "Filme de Quentin Tarantino, que apresenta uma narrativa não linear e tramas entrelaçadas de diferentes personagens.");
            _palavras_e_dicas.Add("os vingadores", "Filme de super-heróis da Marvel que reúne diversos personagens, como Homem de Ferro, Capitão América, Thor e outros.");
            _palavras_e_dicas.Add("a vida e bela", "Filme italiano que conta a história de um pai judeu durante o Holocausto, buscando proteger seu filho com imaginação e humor.");
            _palavras_e_dicas.Add("o clube dos cinco", "Filme clássico dos anos 80 que retrata um grupo de estudantes de diferentes estereótipos durante um dia de detenção na escola.");
            _palavras_e_dicas.Add("o iluminado", "Filme de terror baseado no livro de Stephen King, dirigido por Stanley Kubrick.");
            _palavras_e_dicas.Add("o grande gatsby", "Drama baseado no livro de F. Scott Fitzgerald, que retrata a decadência da alta sociedade nos anos 1920.");
            _palavras_e_dicas.Add("a viagem de chihiro", "Animação japonesa dirigida por Hayao Miyazaki, que se passa em um mundo fantástico cheio de criaturas mágicas.");
            _palavras_e_dicas.Add("a lista de schindler", "Drama histórico dirigido por Steven Spielberg, que retrata a história real de Oskar Schindler durante o Holocausto.");
            _palavras_e_dicas.Add("a origem", "Thriller de ficção científica dirigido por Christopher Nolan, que explora o conceito de invasão dos sonhos.");
        }
    }
}
