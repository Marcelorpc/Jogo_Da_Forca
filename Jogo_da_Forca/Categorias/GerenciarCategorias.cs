using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca.Categorias
{
    public class GerenciarCategorias
    {
        public Dictionary<string, Dictionary<string, string>> categoriasAtivas { get; private set; }
        Animais animais = new Animais();
        Esportes esportes = new Esportes();
        Filmes filmes = new Filmes();

        public GerenciarCategorias() 
        {
            categoriasAtivas = new Dictionary<string, Dictionary<string, string>>();
            adicionarTodasCategorias();
        }

        private void adicionarTodasCategorias()
        {
            categoriasAtivas.Add(animais.Categoria, animais._palavras_e_dicas);
            categoriasAtivas.Add(esportes.Categoria, esportes._palavras_e_dicas);
            categoriasAtivas.Add(filmes.Categoria, filmes._palavras_e_dicas);
        }
    }
}
